using AdminApp.BLL;
using AdminApp.BLL.Facades;
// todo-cleancode commented code why?
//using AdminApp.BLL.Mappers;
using AdminApp.DAL.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace AdminApp.BLL;

public static class BLLInstaller
{
// todo-cleancode why is one installer in App and other on project level?
    public static IServiceCollection AddBLLServices(this IServiceCollection services)
    {
        services.AddSingleton<IUnitOfWorkFactory, UnitOfWorkFactory>();

        services.Scan(selector => selector
            .FromAssemblyOf<BusinessLogic>()
            .AddClasses(filter => filter.AssignableTo(typeof(IFacade<,,>)))
            .AsMatchingInterface()
            .WithSingletonLifetime());

// todo-cleancode commented code why?
/*
        services.Scan(selector => selector
            .FromAssemblyOf<BusinessLogic>()
            .AddClasses(filter => filter.AssignableTo(typeof(ModelMapperBase<,,>)))
            .AsMatchingInterface()
            .WithSingletonLifetime());
*/
        return services;
    }
}