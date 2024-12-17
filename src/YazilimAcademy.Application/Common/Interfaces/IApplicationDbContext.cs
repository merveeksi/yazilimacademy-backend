using Microsoft.EntityFrameworkCore;
using YazilimAcademy.Domain.Entities;

namespace YazilimAcademy.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Category> Categories { get; }
    DbSet<Course> Courses { get; }
    DbSet<CourseCategory> CourseCategories { get; }
    DbSet<CourseSection> CourseSections { get; }
    DbSet<CourseLecture> CourseLectures { get; }
    DbSet<CourseLectureResource> CourseLectureResources { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    int SaveChanges();
}
