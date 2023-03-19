using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.PersonalInfoModel
{
    public record PersonalInfoModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public Guid? ParticipantId { get; set; }
        public ParticipantEntity? Participant { get; set; }

    }
}
