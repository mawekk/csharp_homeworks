using Grades.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Grades.Pages;

[BindProperties]
public class AddGrade : PageModel
{
    private readonly StudentGradeDbContext _context;
    public AddGrade(StudentGradeDbContext context)
        => _context = context;
    public StudentGrade StudentGrade { get; set; } = new();

    public async Task<IActionResult> OnPostAsync()
    {
        _context.StudentGrades.Add(StudentGrade);

        await _context.SaveChangesAsync();
        return RedirectToPage("./Index");
    }
}