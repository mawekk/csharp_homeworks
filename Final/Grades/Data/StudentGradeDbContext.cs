using Microsoft.EntityFrameworkCore;

namespace Grades.Data;

public class StudentGradeDbContext: DbContext
{
    public StudentGradeDbContext(
        DbContextOptions<StudentGradeDbContext> options)
        : base(options)
    {
    }
    public DbSet<StudentGrade> StudentGrades => Set<StudentGrade>();
}