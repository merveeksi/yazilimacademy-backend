using Microsoft.EntityFrameworkCore;
using YazilimAcademy.Application.Common.Interfaces;
using YazilimAcademy.Domain.Entities;

namespace YazilimAcademy.Infrastructure.Persistence.EntityFramework.Contexts;

public sealed class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseCategory> CourseCategories { get; set; }
    public DbSet<CourseSection> CourseSections { get; set; }

    public DbSet<CourseLecture> CourseLectures { get; set; }

    public DbSet<CourseLectureResource> CourseLectureResources { get; set; }
}
