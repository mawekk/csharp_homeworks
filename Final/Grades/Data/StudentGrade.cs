using System.ComponentModel.DataAnnotations;

namespace Grades.Data;

public class StudentGrade
{
    public int StudentGradeID { get; set; }
    
    [Required(ErrorMessage = "Кому выставить оценочку?")]
    public string Name { get; set; } = "";
    
    [Required(ErrorMessage = "А за что оценочку выставить?")]
    public string Subject { get; set; } = "";
    
    [Required(ErrorMessage = "Поставьте оценочку от 0 до 10")]
    [Range(0, 10, ErrorMessage = "Поставьте оценочку от 0 до 10")]
    public int Grade { get; set; }
}