using System.ComponentModel.DataAnnotations;

namespace Solution.DTO;

public class RefreshTokenRequestDTO
{
    [Required]
    public string AccessToken { get; set; }
    [Required]
    public string RefreshToken { get; set; }
}