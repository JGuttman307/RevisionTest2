namespace RevTest2.DTOs;

public record StudentDetailsResponse(
    int Id,
    string FirstName,
    string LastName,
    string Pesel,
    string? Phone,
    IEnumerable<CourseResponse> Courses
);