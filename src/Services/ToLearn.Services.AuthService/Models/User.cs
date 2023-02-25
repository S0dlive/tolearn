using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Identity;

namespace ToLearn.Services.AuthService.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime LastConnection { get; set; }
}