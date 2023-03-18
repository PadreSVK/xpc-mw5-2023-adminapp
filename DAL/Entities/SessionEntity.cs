using AdminApp.Common.Enums;

namespace AdminApp.DAL.Entities;

public record SessionEntity : EntityBase
{
    public required SchoolEnum School { get; set; }
    public required AccomodationEntity Accomodation { get; set; }
}

