namespace AdminApp.BLL.Models.LoginModel
{
    public record LoginModelClass(string Route,Type ViewType, Type ViewModelType)
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
