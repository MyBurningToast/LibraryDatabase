using Microsoft.Data.Sqlite;

/*
 * SQL cheat sheet for reference:
 * https://coddy.tech/cheat-sheets/sql
 */

public static class Db
{
    // the working directory is in the build folder, these files are not copied in so backtrack
    static readonly string Root = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", ".."));
    static readonly string DbPath = Path.Combine(Root, "library.db");

    public static SqliteConnection Open()
    {
        var conn = new SqliteConnection($"Data Source={DbPath};Mode=ReadWrite");
        conn.Open();

        // sqlite will only enforce FKs if this is on for every connection
        Run(conn, "PRAGMA foreign_keys = ON;");
        return conn;
    }

    // builds the db from schema.sql + test_data.sql if the file isn't there yet
    public static void EnsureExists()
    {
        if (!File.Exists(DbPath)) Rebuild();
    }

    public static void Rebuild()
    {
        SqliteConnection.ClearAllPools(); // pooled cons can keep the file locked
        File.Delete(DbPath);

        // ReadWriteCreate makes the new file
        using var conn = new SqliteConnection($"Data Source={DbPath};Mode=ReadWriteCreate");
        conn.Open();
        Run(conn, "PRAGMA foreign_keys = ON;");
        Run(conn, File.ReadAllText(Path.Combine(Root, "schema.sql")));
        Run(conn, File.ReadAllText(Path.Combine(Root, "test_data.sql")));
    }

    static void Run(SqliteConnection conn, string sql)
    {
        using var cmd = conn.CreateCommand();
        cmd.CommandText = sql;
        cmd.ExecuteNonQuery();
    }

    // helper to read sql from a file. the alternative was embedding them as strings in the code
    public static string Sql(string name) => File.ReadAllText(Path.Combine(Root, "queries", name + ".sql"));
}