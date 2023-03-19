using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using AdminApp.Common.Enums;
namespace AdminApp.DAL.Seeds;

public static class StaffSeeds
{

    public static readonly StaffEntity Staff1 = new()
    {
        Id = Guid.NewGuid(),
        FirstName = "adam",
        LastName = "Novak",
        EmailAddress = "adam@seznam.cz",
        PhoneNumber = "1234567890",
        BirthDate = DateTime.Parse("7/5/2000 8:30:52 AM"),
        Gender = GenderEnum.Male,
        AddressLine1 = "Chanov",
        AddressLine2 = "2",
        City = "Blava",
        Country = "Slovensko",
        PostalCode = "377 78",
        DepartmentId = DepartmentSeeds.Department1.Id,
        StaffAccomodationId = StaffAccomodationSeeds.StaffAccomodation1.Id,
    };
    public static readonly StaffEntity Staff2 = new()
    {
        Id = Guid.NewGuid(),
        FirstName = "adela",
        LastName = "Nemcova",
        EmailAddress = "adela@seznam.cz",
        PhoneNumber = "123488890",
        BirthDate = DateTime.Parse("7/5/2002 8:30:52 AM"),
        Gender = GenderEnum.Female,
        AddressLine1 = "Chanov",
        AddressLine2 = "2",
        City = "Kosice",
        Country = "Slovensko",
        PostalCode = "377 78",
        DepartmentId = DepartmentSeeds.Department2.Id,
        StaffAccomodationId = StaffAccomodationSeeds.StaffAccomodation1.Id,
    };
    public static readonly StaffEntity Staff3 = new()
    {
        Id = Guid.NewGuid(),
        FirstName = "Aneta",
        LastName = "Novakova",
        EmailAddress = "aneta@seznam.cz",
        PhoneNumber = "125896487",
        BirthDate = DateTime.Parse("1/1/2001 8:30:52 AM"),
        Gender = GenderEnum.Female,
        AddressLine1 = "Chanov",
        AddressLine2 = "2",
        City = "Ostrava",
        Country = "Cesko",
        PostalCode = "377 78",
        DepartmentId = DepartmentSeeds.Department1.Id,
        StaffAccomodationId = StaffAccomodationSeeds.StaffAccomodation1.Id,
    };

    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<StaffEntity>().HasData(Staff1,Staff2, Staff3);
}
