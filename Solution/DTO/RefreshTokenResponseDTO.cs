namespace Solution.DTO;

public class RefreshTokenResponseDTO
{
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiration { get; set; }
}