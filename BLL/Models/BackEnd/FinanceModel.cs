using AdminApp.DAL.Entities;

namespace AdminApp.BLL.Models.FinanceModel
{
    public record FinanceModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public Guid? Id { get; set; }
        public int? Amount { get; set; }
        public Guid? ParticipantId { get; set; }
        public ParticipantEntity? Participant { get; set; }
    }
}
