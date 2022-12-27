using System.Threading.Tasks;
using Grades.Data;

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
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.StudentGrades.Add(StudentGrade);

        await _context.SaveChangesAsync();
        return RedirectToPage("Index");
    }
}