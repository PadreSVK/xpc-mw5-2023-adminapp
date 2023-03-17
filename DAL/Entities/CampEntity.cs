using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record CampEntity : EntityBase
{
    public required ICollection<SessionEntity> Sessions { get; set; }

}

