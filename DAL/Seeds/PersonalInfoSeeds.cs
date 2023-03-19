using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class PersonalInfoSeeds
{

    public static readonly PersonalInfoEntity PersonalInfo1 = new()
    {
        Id = Guid.NewGuid(),
        AddressLine1 = "Chanov",
        AddressLine2 = "2",
        City = "Olomouc",
        Country = "Cesko",
        PostalCode = "377 78",
        ParticipantId = ParticipantSeeds.Participant1.Id,

    };
    public static readonly PersonalInfoEntity PersonalInfo2 = new()
    {
        Id = Guid.NewGuid(),
        AddressLine1 = "Chanov",
        AddressLine2 = "2",
        City = "Hradec",
        Country = "Cesko",
        PostalCode = "377 78",
        ParticipantId = ParticipantSeeds.Participant2.Id,

    };
    public static readonly PersonalInfoEntity PersonalInfo3 = new()
    {
        Id = Guid.NewGuid(),
        AddressLine1 = "Chanov",
        AddressLine2 = "2",
        City = "Blava",
        Country = "Slovensko",
        PostalCode = "377 78",
        ParticipantId = ParticipantSeeds.Participant3.Id,

    };
    public static readonly PersonalInfoEntity PersonalInfo4 = new()
    {
        Id = Guid.NewGuid(),
        AddressLine1 = "Zabiny",
        AddressLine2 = "2",
        City = "Brno",
        Country = "Cesko",
        PostalCode = "377 78",
        ParticipantId = ParticipantSeeds.Participant4.Id,

    };
    public static readonly PersonalInfoEntity PersonalInfo5 = new()
    {
        Id = Guid.NewGuid(),
        AddressLine1 = "Chanov",
        AddressLine2 = "2",
        City = "Brno",
        Country = "Cesko",
        PostalCode = "377 78",
        ParticipantId = ParticipantSeeds.Participant5.Id,

    };

    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<PersonalInfoEntity>().HasData(PersonalInfo1, PersonalInfo2, PersonalInfo3, PersonalInfo4, PersonalInfo5);
}