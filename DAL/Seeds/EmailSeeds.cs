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
    public static readonly EmailEntity Email4 = new()
    {
        Id = Guid.Parse("ee140da2-471b-49cc-a2f7-a17e45e4d603"),
        Email = "pavel@seznam.cz",
        RegistrationId = RegistrationSeeds.Registration4.Id

    };
    public static readonly EmailEntity Email5 = new()
    {
        Id = Guid.Parse("d016617c-f54b-431c-ae17-e6c696e203ed"),
        Email = "petra@seznam.cz",
        RegistrationId = RegistrationSeeds.Registration5.Id

    };
    public static readonly EmailEntity Email6 = new()
    {
        Id = Guid.Parse("fd993c3f-0871-4e0f-8c7e-5e6d25f0a6a9"),
        Email = "jana@seznam.cz",
        RegistrationId = RegistrationSeeds.Registration6.Id

    };


    public static void Seed(this ModelBuilder modelBuilder) => 
        modelBuilder.Entity<EmailEntity>().HasData(Email1, Email2, Email3,Email4, Email5, Email6);

    
    


}
