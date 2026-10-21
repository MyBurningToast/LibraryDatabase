using System.Globalization;
namespace App;

record Loan(string Student, string Book, DateTime Out, DateTime Due)
{
    public DateTime? Returned { get; set; }
}

// TESTING DATA
// TODO: link to database
class Library
{
    public List<string> Students { get; } = new() { "a aa", "b bb", "c cc", "d dd"};

    public List<string> Books { get; } = new() { "book_a", "book_b", "book_c" };

    public List<Loan> Loans { get; } = new();

    public static Library Fakedata()
    {
        var lib = new Library();
        DateTime D(string s) => DateTime.Parse(s, CultureInfo.InvariantCulture);
        void Add(string who, string book, string o, string due, string? ret = null) =>
            lib.Loans.Add(new Loan(who, book, D(o), D(due)) { Returned = ret is null ? null : D(ret) });

        Add("a aa", "book_a", "2026-09-05", "2026-09-19");
        Add("b bb", "book_b", "2026-09-10", "2026-09-24");
        return lib;
    }
}
