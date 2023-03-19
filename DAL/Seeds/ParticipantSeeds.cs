using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using AdminApp.Common.Enums;

namespace AdminApp.DAL.Seeds;

public static class ParticipantSeeds
{

    public static readonly ParticipantEntity Participant1 = new()
    {
        Id = Guid.Parse("eaca4c40-e26c-4c36-8e9a-5c23e38a2a81"),
        RegistrationStatus = RegistrationStatusEnum.Registered,
        
        AccomodationId = AccomodationSeeds.Accomodation1.Id,
    };

    public static readonly ParticipantEntity Participant2 = new()
    {
        Id = Guid.Parse("29cf03eb-19c0-4098-895a-225cf1999128"),
        RegistrationStatus = RegistrationStatusEnum.Registered,
        
        AccomodationId = AccomodationSeeds.Accomodation1.Id,
    };

    public static readonly ParticipantEntity Participant3 = new()
    {
        Id = Guid.Parse("17c77449-ae49-4d4b-95df-d3307295734f"),
        RegistrationStatus = RegistrationStatusEnum.DepositPaid,
        
        AccomodationId = AccomodationSeeds.Accomodation1.Id,
    };
  
    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<ParticipantEntity>().HasData(Participant1, Participant2, Participant3);

}