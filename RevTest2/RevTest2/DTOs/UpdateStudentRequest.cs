using System.ComponentModel.DataAnnotations;

namespace RevTest2.DTOs;

public record UpdateStudentRequest(
    [MaxLength(100)] string FirstName,
    [MaxLength(100)]  string LastName,
    [MaxLength(11), MinLength(11)] string Pesel,
    [MaxLength(9), MinLength(9)] string? Phone
);