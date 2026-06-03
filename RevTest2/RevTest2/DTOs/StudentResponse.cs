namespace RevTest2.DTOs;

public record StudentResponse(
    int Id,
    string FirstName,
    string LastName,
    string Pesel,
    string? Phone
    );