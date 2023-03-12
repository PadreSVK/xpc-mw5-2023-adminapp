using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace AdminApp.DAL.Seeds;

public static class RegistrationSeeds
{
    public static readonly RegistrationEntity ExampleRegistration = new()
    {
        Id = Guid.Parse("db68702a-765b-43b8-8b9b-af213d69d15b"),
        FirstName = "x",
        LastName = "x",
        EmailAddress = "x",
        PhoneNumber = "x",
        Department = Common.Enums.DepartmentEnum.Mathematics,
        BirthDate = DateTime.Parse("2/16/2008 12:15:12 PM"),
        Gender = Common.Enums.Gender.Male,
        Session = Common.Enums.Session.FirstVSPJ,
        TransportMode = Common.Enums.TransportMode.Bus,
        RegistrationStatus = Common.Enums.RegistrationStatus.Registered
    };

    public static readonly RegistrationEntity AnotherRegistration = new()
    {
        Id = Guid.Parse("x"),
        FirstName = "x",
        LastName = "x",
        EmailAddress = "x",
        PhoneNumber = "x",
        Department = Common.Enums.DepartmentEnum.EconomicStudies,
        BirthDate = DateTime.Parse("2/16/2008 12:15:12 PM"),
        Gender = Common.Enums.Gender.Male,
        Session = Common.Enums.Session.FirstVSPJ,
        TransportMode = Common.Enums.TransportMode.Individual,
        RegistrationStatus = Common.Enums.RegistrationStatus.DepositPaid
    };

    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<RegistrationEntity>().HasData(
            AnotherRegistration with { Roommates = Array.Empty<RegistrationEntity>() }
        );
}
