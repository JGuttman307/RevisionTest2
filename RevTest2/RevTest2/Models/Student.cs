namespace RevTest2.Models;

public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Pesel { get; set; } = string.Empty;
    public string? Phone { get; set; }
    
    public ICollection<StudentCourse> StudentCourses { get; set; }
}