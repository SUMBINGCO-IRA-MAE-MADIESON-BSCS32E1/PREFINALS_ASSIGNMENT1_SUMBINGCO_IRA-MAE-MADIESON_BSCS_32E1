using AuthServer.Core;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IAuthService _authService;

    public AuthController(IUserService userService, IAuthService authService)
    {
        _userService = userService;
        _authService = authService;
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] User user)
    {
        _userService.Register(user);
        return Ok();
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] User user)
    {
        var authenticatedUser = _userService.Authenticate(user.Username, user.PasswordHash);
        if (authenticatedUser == null)
            return Unauthorized();

        var token = _authService.GenerateToken(authenticatedUser);
        return Ok(new { Token = token });
    }
}