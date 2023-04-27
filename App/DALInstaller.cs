using AdminApp.App.Options;
using AdminApp.DAL.Factories;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using AdminApp.DAL.Mappers;
using AdminApp.DAL;

namespace AdminApp.App;

public static class DALInstaller
{
    //todo-other / maybe move to DAL? 
    public static IServiceCollection AddDALServices(this IServiceCollection services, IConfiguration configuration)
    {
        DALOptions dalOptions = new();
        configuration.GetSection("AdminApp:DAL").Bind(dalOptions);

        services.AddSingleton<DALOptions>(dalOptions);
        // todo-other
        // services.Configure<PositionOptions>(builder.Configuration.GetSection("AdminApp:DAL"));
        // https://andrewlock.net/adding-validation-to-strongly-typed-configuration-objects-in-dotnet-6/

        if (dalOptions.PostgreSqlServer is null)
        {
            //todo-other why invalid operation? create own exception..
            throw new InvalidOperationException("No persistence provider configured");
        }

        // todo-maintability why to use some flag that lead to fail on start of app? 
        if (dalOptions.PostgreSqlServer?.Enabled == false)
        {
            throw new InvalidOperationException("No persistence provider enabled");
        }
        
        if (dalOptions.PostgreSqlServer?.Enabled == true)
        {
            //todo-maintability why to not use UseNpgsql?
            // https://www.npgsql.org/efcore/
            services.AddSingleton<IDbContextFactory<AdminAppDbContext>>(provider => new SqlServerDbContextFactory(dalOptions.PostgreSqlServer.PostgreSqlConnection));
            services.AddSingleton<IDbMigrator, PostgreSqlDbMigrator>();
        }

        services.AddSingleton<AccomodationEntityMapper>();
        services.AddSingleton<AccomodationTypeEntityMapper>();
        services.AddSingleton<BarInventoryEntityMapper>();
        services.AddSingleton<BarItemEntityMapper>();
        services.AddSingleton<CampEntityMapper>();
        services.AddSingleton<CurrentYearEntityMapper>();
        services.AddSingleton<DepartmentEntityMapper>();
        services.AddSingleton<DrinkEntityMapper>();
        services.AddSingleton<DrinkIngredientEntityMapper>();
        services.AddSingleton<EmailEntityMapper>();
        services.AddSingleton<ParticipantEntityMapper>();
        services.AddSingleton<PaymentEntityMapper>();
        services.AddSingleton<PersonalInfoEntityMapper>();
        services.AddSingleton<RegistrationEntityMapper>();
        services.AddSingleton<RoomMateEntityMapper>();
        services.AddSingleton<SchoolEntityMapper>();
        services.AddSingleton<SessionEntityMapper>();
        services.AddSingleton<StaffAcomodationEntityMaper>();
        services.AddSingleton<StaffEntityMapper>();


        return services;
    }
}
