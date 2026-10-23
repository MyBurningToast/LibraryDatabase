using System.Globalization;
using Microsoft.Data.Sqlite;
namespace App;

record Item(long Id, string Name);

record Loan(long Id, string Student, string Book, DateTime Out, DateTime Due)
{
    public DateTime? Returned { get; init; }
}

static class Library
{
    public static List<Item> Students() => ReadItems("students");
    public static List<Item> AvailableBooks() => ReadItems("books_available");
    public static List<Loan> LoansOut() => ReadLoans("currently_out");
    public static List<Loan> Overdue() => ReadLoans("overdue");
    public static List<Loan> SearchStudents(string q) => ReadLoans("search_students", ("@q", $"%{q}%"));
    public static List<Loan> SearchBooks(string q) => ReadLoans("search_books", ("@q", $"%{q}%"));

    public static void AddLoan(long studentId, long bookId, DateTime due)
    {
        using var conn = Db.Open();
        using var cmd = Command(conn, "add_loan", ("@student", studentId), ("@book", bookId), ("@out", Fmt(DateTime.Today)), ("@due", Fmt(due)));
        cmd.ExecuteNonQuery();
    }

    public static void MarkReturned(long loanId)
    {
        using var conn = Db.Open();
        using var cmd = Command(conn, "mark_returned", ("@id", loanId), ("@date", Fmt(DateTime.Today)));
        cmd.ExecuteNonQuery();
    }

    public static bool AddStudent(long id, string name, out bool wasCheckError)
    {
        using var conn = Db.Open();
        using var cmd = Command(conn, "add_student", ("@id", id), ("@name", name));
        return TryInsert(cmd, out wasCheckError);
    }

    public static bool AddBook(long id, string title, string author, out bool wasCheckError)
    {
        using var conn = Db.Open();
        using var cmd = Command(conn, "add_book", ("@id", id), ("@title", title), ("@author", author));
        return TryInsert(cmd, out wasCheckError);
    }

    static bool TryInsert(SqliteCommand cmd, out bool wasCheckError)
    {
        wasCheckError = false;
        try
        {
            cmd.ExecuteNonQuery();
            return true;
        }
        // 1555 is SQLITE_CONSTRAINT_PRIMARYKEY
        // this error happens whne and INSERT or UPDATE op violates the tbales PK contraint (no duplicates)
        catch (SqliteException e) when (e.SqliteExtendedErrorCode == 1555)
        {
            return false;
        }
        // this error code is for the CHECK constraint failures
        catch (SqliteException e) when (e.SqliteExtendedErrorCode == 275)
        {
            wasCheckError = true;
            return false;
        }

    }

    static List<Item> ReadItems(string file)
    {
        using var conn = Db.Open();
        using var cmd = Command(conn, file);
        using var r = cmd.ExecuteReader();
        var list = new List<Item>();
        // loop though database result set row by row r.Read() is ture if there is another row to prossess
        while (r.Read())
        {
            // for every row found create a new Item instance (first and 2nd column)
            list.Add(new Item(r.GetInt64(0), r.GetString(1)));
        }
        return list;
    }

    // columns must be: LoanID, student, book, DateOut, DateDue, DateReturned
    static List<Loan> ReadLoans(string file, params (string, object)[] args)
    {
        using var conn = Db.Open();
        using var cmd = Command(conn, file, args);
        using var r = cmd.ExecuteReader();
        var list = new List<Loan>();
        while (r.Read())
        {
            list.Add(new Loan(r.GetInt64(0), r.GetString(1), r.GetString(2), Parse(r.GetString(3)), Parse(r.GetString(4)))
            {
                // null means not reutrned yet
                Returned = r.IsDBNull(5) ? null : Parse(r.GetString(5))
            });
        }
        return list;
    }

    static SqliteCommand Command(SqliteConnection conn, string file, params (string, object)[] args)
    {
        var cmd = conn.CreateCommand();
        cmd.CommandText = Db.Sql(file);
        foreach (var (name, value) in args)
        {
            cmd.Parameters.AddWithValue(name, value);
        }
        return cmd;
    }

    // format dates as year-month-day this is beacsue SQLite doesnt have a date type, so doing this lets me do comparisions and sorting
    static string Fmt(DateTime d) => d.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture); // culture info makes it so that its consistant no matter what region the users pc is set to
    static DateTime Parse(string s) => DateTime.ParseExact(s, "yyyy-MM-dd", CultureInfo.InvariantCulture);
}