namespace AdminApp.App.Options;


public record DALOptions
{
    public SqlServerOptions? SqlServer { get; init; }
}

public record SqlServerOptions
{
    public bool Enabled { get; init; }
    public string SqlServerConnection { get; init; } = null!;
}
