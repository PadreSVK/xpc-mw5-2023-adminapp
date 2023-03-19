using AdminApp.Common.Enums;
using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.ParticipantAdminModel
{
    public record ParticipantAdminModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public RegistrationStatusEnum? RegistrationStatus { get; set; }
        public RegistrationEntity? Registration { get; set; }
        public PersonalInfoEntity? PersonalInfo { get; set; }
        public AccomodationEntity? Accomodation { get; set; }
        public Guid? AccomodationId { get; set; }
        public ICollection<PaymentEntity> Payments { get; set; } = new List<PaymentEntity>();


    }
}
