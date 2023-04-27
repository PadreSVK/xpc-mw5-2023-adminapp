namespace AdminApp.BLL.Models.LoginModel
{
    // todo-maintability why are in BL FE models?
    public record LoginModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
