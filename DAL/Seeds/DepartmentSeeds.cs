using AdminApp.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdminApp.DAL.Seeds;

public static class DepartmentSeeds
{

    public static readonly DepartmentEntity Department1 = new()
    {
        Id = Guid.Parse("bb329a95-687f-4fa5-8d42-f56913a11fef"),
        DepartmentName = "FEKT",
        DepartmentNumber = 1,
        SchoolId = SchoolSeeds.School.Id,
    };

    public static readonly DepartmentEntity Department2 = new()
    {
        Id = Guid.Parse("b9ddc68a-8670-4040-af34-ef69a093d010"),
        DepartmentName = "FSS",
        DepartmentNumber = 1,
        SchoolId = SchoolSeeds.School2.Id,
    };



    public static void Seed(this ModelBuilder modelBuilder) =>
        modelBuilder.Entity<DepartmentEntity>().HasData(Department1,Department2);

}
