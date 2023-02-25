using ToLearn.Services.AuthService.Models;

namespace ToLearn.Services.AuthService.Service;

public class UserProfileService
{
    public async Task<ProfileUser> ApplicationUserToProfileUser(ApplicationUser user)
    {
        return new ProfileUser()
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Id = user.Id,
            Username = user.UserName
        };
    }
}