using System.ComponentModel.DataAnnotations;

namespace Solution.DTO;
public class LoginRequestDTO
{
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
}