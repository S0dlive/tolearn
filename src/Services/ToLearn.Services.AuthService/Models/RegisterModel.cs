namespace ToLearn.Services.AuthService.Models;

public record RegisterModel(string Username, string Password, string Email, string FirstName, string LastName);

public record LoginDto(string Email, string Password);
