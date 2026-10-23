# Library Database

School library database app for NCEA Level 2 (AS91892). A Windows desktop app made with C# WinForms and SQLite that tracks students, books and loans.

## Run it

1. Download the zip [Releases](../../releases/latest)
2. Unzip somewhere you can write to (not Program Files)
3. Run `App.exe`

`library.db` is created from `schema.sql` and `test_data.sql`. If you want to go back to a fresh database, just delete the `library.db` file and it will automatically rebuild it.

## Build from source

Needs the .NET 10 SDK.

    dotnet run --project App/App.csproj

## Layout

- `App/` - the WinForms app
- `queries/` - SQL used by the app
- `schema.sql` - table definitions
- `test_data.sql` - seed data
