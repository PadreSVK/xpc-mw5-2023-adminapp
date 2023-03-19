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
    public static readonly AccomodationEntity Accomodation3 = new()
    {
        Id = Guid.Parse("07e3db53-c96b-48a8-b4b4-380da759938a"),
        AccomodationNumber = 3,
        SessionId = SessionSeeds.Session1.Id,
    };
    public static readonly AccomodationEntity Accomodation4 = new()
    {
        Id = Guid.Parse("7ad0de6b-c0b8-4b11-a292-077994357f34"),
        AccomodationNumber = 4,
        SessionId = SessionSeeds.Session1.Id,
    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<AccomodationEntity>().HasData(Accomodation1,Accomodation2, Accomodation3, Accomodation4);

}
