using AdminApp.BLL.Options;
using AdminApp.DAL.Factories;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using AdminApp.DAL.Mappers;
using AdminApp.DAL;

namespace AdminApp.BLL;

public static class DALInstaller
{
    public static IServiceCollection AddDALServices(this IServiceCollection services, IConfiguration configuration)
    {
        DALOptions dalOptions = new();
        configuration.GetSection("AdminApp:DAL").Bind(dalOptions);

        services.AddSingleton<DALOptions>(dalOptions);

        if (dalOptions.SqlServer is null)
        {
            throw new InvalidOperationException("No persistence provider configured");
        }

        if (dalOptions.SqlServer?.Enabled == false)
        {
            throw new InvalidOperationException("No persistence provider enabled");
        }
        
        if (dalOptions.SqlServer?.Enabled == true)
        {
            services.AddSingleton<IDbContextFactory<AdminAppDbContext>>(provider => new SqlServerDbContextFactory(dalOptions.SqlServer.SqlServerConnection));
            services.AddSingleton<IDbMigrator, SqlServerDbMigrator>();
        }

        services.AddSingleton<RegistrationEntityMapper>();
        services.AddSingleton<EmailEntityMapper>();


        return services;
    }
}
