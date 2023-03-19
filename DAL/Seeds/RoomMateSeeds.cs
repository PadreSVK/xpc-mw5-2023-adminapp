using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class RoomMateSeeds
{
    
    public static readonly RoomMateEntity RoomMate1 = new()
    {
        Id = Guid.Parse("3ac0a05b-5d43-4d14-9a74-ea01dfc73211"),
        RoommateEmail = "josef@seznam.cz",
        RegistrationId = RegistrationSeeds.Registration1.Id,
        

    };

    public static readonly RoomMateEntity RoomMate2 = new()
    {
        Id = Guid.Parse("006827d2-a022-4bb6-9fff-1301ff9ac533"),
        RoommateEmail = "jakub@seznam.cz",
        RegistrationId = RegistrationSeeds.Registration1.Id,
        

    };

   

    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<RoomMateEntity>().HasData(RoomMate1, RoomMate2);
    
}
