using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToLearn.Services.AuthService.Models;
using ToLearn.Services.AuthService.Service;

namespace ToLearn.Services.AuthService.Controllers;

[Route("api/v1/user")]
public class UserController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserProfileService _userProfileService;

    public UserController(
        UserProfileService userProfileService,
        SignInManager<ApplicationUser> signInManager,
        UserManager<ApplicationUser> userManager)
    {
        _userProfileService = userProfileService;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserProfilWithId(string id)
    {
        ApplicationUser user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);
        if (user != null)
        {
            return Ok(_userProfileService.ApplicationUserToProfileUser(user));
        }
        return NotFound();
    }
}