using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Grades.Data;

namespace Grades;

public class GradesTable : PageModel
{
    private readonly StudentGradeDbContext context;
    public GradesTable(StudentGradeDbContext context)
        => this.context = context;
    public IList<StudentGrade> StudentGrades { get; private set; } = new List<StudentGrade>();
    public void OnGet()
    {
        StudentGrades = context.StudentGrades.OrderBy(p => p.StudentGradeID).ToList();
    }
}