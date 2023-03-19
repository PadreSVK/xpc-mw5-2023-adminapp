using Microsoft.AspNetCore.Mvc;
using AdminApp.DAL.Entities;
using Microsoft.VisualBasic;

namespace AdminApp.BLL.Controllers;

[ApiController]
[Route("[controller]")]
public class RegistrationController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<RegistrationController> _logger;

    public RegistrationController(ILogger<RegistrationController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public RegistrationEntity Get()
    {
        return new RegistrationEntity
        {
            Id = Guid.NewGuid(),
            FirstName = "jakub",
            LastName = "mahdal",
            EmailAddress = new EmailEntity() { Email = "matej@matej", Id = Guid.NewGuid() },
            PhoneNumber = "777334077",
            Department = new DepartmentEntity() { DepartmentName = "neco", DepartmentNumber = 1, Id = Guid.NewGuid() },
            BirthDate = DateTime.Now,
            Gender = Common.Enums.GenderEnum.Male,
            TransportMode = Common.Enums.TransportModeEnum.Bus
        };
    }
}