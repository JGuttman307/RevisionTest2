namespace RevTest2.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    
    public ICollection<StudentCourse> StudentCourses { get; set; }
}