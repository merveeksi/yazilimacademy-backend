using Microsoft.EntityFrameworkCore;
using YazilimAcademy.Domain.Entities;

namespace YazilimAcademy.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Category> Categories { get; }
    DbSet<City> Cities { get; }
    DbSet<Country> Countries { get; }
    DbSet<Course> Courses { get; }
    DbSet<CourseCategory> CourseCategories { get; }
    DbSet<CourseComment> CourseComments { get; }
    DbSet<CourseInstructor> CourseInstructors { get; }
    DbSet<CourseLecture> CourseLectures { get; }
    DbSet<CourseLectureResource> CourseLectureResources { get; }
    DbSet<CourseSection> CourseSections { get; }
    DbSet<Instructor> Instructors { get; }
    DbSet<InstructorSocialMediaLink> InstructorSocialMediaLinks { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    int SaveChanges();
}
