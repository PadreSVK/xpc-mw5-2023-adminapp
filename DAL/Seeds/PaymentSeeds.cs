using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class PaymentSeeds
{
    public static readonly PaymentEntity Payment1 = new()
    {
        Id = Guid.NewGuid(),
        Amount = 1000,
        ParticipantId = ParticipantSeeds.Participant1.Id,

    };
    public static readonly PaymentEntity Payment2 = new()
    {
        Id = Guid.NewGuid(),
        Amount = 500,
        ParticipantId = ParticipantSeeds.Participant1.Id,

    };
    public static readonly PaymentEntity Payment3 = new()
    {
        Id = Guid.NewGuid(),
        Amount = 1500,
        ParticipantId = ParticipantSeeds.Participant2.Id,

    };
    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<PaymentEntity>().HasData(Payment1, Payment2, Payment3);

}
