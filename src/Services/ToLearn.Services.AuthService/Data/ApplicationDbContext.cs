using Microsoft.EntityFrameworkCore;

namespace ToLearn.Services.AuthService.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}