namespace App;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Db.EnsureExists();
        Application.Run(new MainForm());
    }
}