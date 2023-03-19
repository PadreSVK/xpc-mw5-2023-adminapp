using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class AccomodationSeeds
{

    public static readonly AccomodationEntity Accomodation1 = new()
    {
        Id = Guid.Parse("e028b618-078c-4211-80c8-bffa72785dfe"),
        AccomodationNumber = 1,
        SessionId = SessionSeeds.Session1.Id,
    };

    public static readonly AccomodationEntity Accomodation2 = new()
    {
        Id = Guid.Parse("6cbcc187-25c3-435d-8c09-c9e621da3763"),
        AccomodationNumber = 2,
        SessionId = SessionSeeds.Session1.Id,
    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<AccomodationEntity>().HasData(Accomodation1,Accomodation2);

}
