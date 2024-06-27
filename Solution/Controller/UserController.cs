using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solution.DTO;
using Solution.Service;

namespace Solution.Controller;

[ApiController]
[Route("/api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;
    
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
   
    [HttpPost("register")]
    [AllowAnonymous]
    public async Task<IActionResult> RegisterAsync([FromBody] RegisterRequestDTO dto)
    {
        await _userService.Register(dto);
        return NoContent();
    }
    
  
    [HttpPost("login")]
    public async Task<IActionResult> LoginAsync([FromBody] LoginRequestDTO dto)
    {
        var response = await _userService.Login(dto);
        
        return Ok(response);
    }
    
    
    [HttpPost("refresh")]
    public async Task<IActionResult> RefreshTokenAsync([FromBody] RefreshTokenRequestDTO dto)
    {
        var response = await _userService.RefreshToken(dto);
        
        return Ok(response);
    }
}