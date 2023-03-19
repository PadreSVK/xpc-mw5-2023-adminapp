using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class SchoolSeeds
{

    public static readonly SchoolEntity School = new()
    {
        Id = Guid.Parse("b57a2923-ecd8-4aad-be0e-3e2bcae20f0a"),
        SchoolNumber = 1,
        SchoolName = "VUT"
    };
    public static readonly SchoolEntity School2 = new()
    {
        Id = Guid.Parse("46a1aef2-b64a-4ea0-8bb0-8bc252996077"),
        SchoolNumber = 2,
        SchoolName = "MUNI"
    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<SchoolEntity>().HasData(School2,School);

}
