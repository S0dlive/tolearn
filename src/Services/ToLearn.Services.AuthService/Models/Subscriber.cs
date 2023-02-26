using System.ComponentModel.DataAnnotations;

namespace ToLearn.Services.AuthService.Models;

public class Subscriber
{
    [Key]
    public string Id { get; set; }
    public string ViseId { get; set; }
    public string FollowersId { get; set; }
}