using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class SessionSeeds
{

    public static readonly SessionEntity Session1 = new()
    {
        Id = Guid.Parse("835bb548-dfc3-429d-802e-6605b2f9eaf7"),
        SessionName = "prvnisession",
        CampId = CampSeeds.Camp1.Id,
        
    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<SessionEntity>().HasData(Session1);
    
       

}
