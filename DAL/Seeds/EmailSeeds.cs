using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class EmailSeeds
{
    
    public static readonly EmailEntity SomeEmail = new()
    {
        Id = Guid.Parse("f74f5054-c552-4b4c-89db-4ac340f523e9"),
        Email = "matej@matej",
        RegistrationId = RegistrationSeeds.ExampleRegistration.Id
        /*
        RegistrationEntityId = Guid.Parse("db68702a-765b-43b8-8b9b-af213d69d15b"),
        Id = Guid.Parse("f74f5054-c552-4b4c-89db-4ac340f523e9"),
        EmailAddress = "malysa.matej@gmail.com",
        RegistrationEntity = RegistrationSeeds.ExampleRegistration
        */
    };
    
    public static readonly EmailEntity SomeOtherEmail = new()
    {
        Id = Guid.Parse("5a7da5d6-300e-4d27-8fcb-ecc4bd7a2213"),
        Email = "josef@josef",
        RegistrationId = RegistrationSeeds.AnotherRegistration.Id
        /*
        RegistrationEntityId = Guid.Parse("db68702a-764b-43b8-8b9b-af213d69d15b"),
        Id = Guid.Parse("1f54e56d-7344-4925-8c4d-fa62d54ecbdd"),
        EmailAddress = "malysa.matej2@gmail.com",
        RegistrationEntity = RegistrationSeeds.AnotherRegistration
        */
    };
    
    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<EmailEntity>().HasData(SomeEmail, SomeOtherEmail);


}
