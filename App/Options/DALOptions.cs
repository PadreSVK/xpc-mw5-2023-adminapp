namespace AdminApp.App.Options;

public record DALOptions
{
    public PostgreSqlOptions? PostgreSqlServer { get; init; }
}

public record PostgreSqlOptions
{
    public bool Enabled { get; init; }
    public string PostgreSqlConnection { get; init; } = null!;
}
