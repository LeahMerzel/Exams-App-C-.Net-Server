using Exams_App_C__.Net_Server.Core.Repositories;
using Exams_App_C__.Net_Server.Data.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthRepository authRepository;

    public AuthController(AuthRepository authRepository)
    {
        this.authRepository = authRepository;
    }

    [HttpPost("login")]
    public async Task<ActionResult<User>> LoginAsync(User userLogin)
    {
        var user = await authRepository.LoginAsync(userLogin);
        if (user == null)
        {
            return NotFound("Invalid email or password");
        }
        return Ok(user);
    }

    [HttpPost("register")]
    public async Task<ActionResult<int>> RegisterAsync(User registerUser)
    {
        var result = await authRepository.RegisterAsync(registerUser);
        if (result == 0)
        {
            return BadRequest("Failed to register user");
        }
        return Ok(result);
    }

    [HttpPut("update")]
    public async Task<ActionResult<bool>> UpdateUserAsync(User user)
    {
        var result = await authRepository.UpdateUserAsync(user);
        if (!result)
        {
            return NotFound("User not found");
        }
        return Ok(result);
    }

    [HttpGet("user/{userId}")]
    public async Task<ActionResult<User>> GetUser(string userId)
    {
        var user = await authRepository.GetUser(userId);
        if (user == null)
        {
            return NotFound("User not found");
        }
        return Ok(user);
    }

}

