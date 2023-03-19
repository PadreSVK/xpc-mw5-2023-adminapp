using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class EmailSeeds
{
 
    
    public static readonly EmailEntity Email1 = new()
    {
        Id = Guid.Parse("c46b865c-be42-4819-a54d-86587a20cbe0"),
        Email = "matej@seznam.cz",
        RegistrationId = RegistrationSeeds.Registration1.Id

    };

    public static readonly EmailEntity Email2 = new()
    {
        Id = Guid.Parse("eeb50afa-5a08-4f7e-9245-a645dc7a5459"),
        Email = "josef@seznam.cz",
        RegistrationId = RegistrationSeeds.Registration2.Id

    };

    public static readonly EmailEntity Email3 = new()
    {
        Id = Guid.Parse("c3ba1354-14c2-437d-abe5-36b14c9df801"),
        Email = "jakub@seznam.cz",
        RegistrationId = RegistrationSeeds.Registration3.Id

    };

  
    public static void Seed(this ModelBuilder modelBuilder) => 
        modelBuilder.Entity<EmailEntity>().HasData(Email1, Email2, Email3);

    
    


}
