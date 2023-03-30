using AdminApp.BLL;
using AdminApp.BLL.Facades;
//using AdminApp.BLL.Mappers;
using AdminApp.DAL.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace CookBook.BL;

public static class BLLInstaller
{
    public static IServiceCollection AddBLLServices(this IServiceCollection services)
    {
        services.AddSingleton<IUnitOfWorkFactory, UnitOfWorkFactory>();

        services.Scan(selector => selector
            .FromAssemblyOf<BusinessLogic>()
            .AddClasses(filter => filter.AssignableTo(typeof(IFacade<,,>)))
            .AsMatchingInterface()
            .WithSingletonLifetime());
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