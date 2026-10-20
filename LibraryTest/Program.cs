Db.Rebuild(); // just for testing

using var conn = Db.Open();

Print("currently out", Db.Sql("currently_out"));
Print("overdue", Db.Sql("overdue"));

void Print(string heading, string sql)
{
    Console.WriteLine("\n" + heading);
    using var cmd = conn.CreateCommand(); // DbCommands are unmanaged resources
    cmd.CommandText = sql;
    using var reader = cmd.ExecuteReader();
    while (reader.Read())
    {
        var cols = new string[reader.FieldCount];
        for (int i = 0; i < cols.Length; i++)
        {
            cols[i] = reader.GetValue(i).ToString()!;
        }
        Console.WriteLine(string.Join(" ", cols));
    }
}