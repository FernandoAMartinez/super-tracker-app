using System.ComponentModel.DataAnnotations;

namespace SuperTrackerApp.Models;

public class UserModel
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }

    public bool RememberMe { get; set; }
}
