using Microsoft.AspNetCore.Mvc;

namespace DotNetAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController: ControllerBase
{
    public UserController()
    {
    }

    [HttpGet("GetUsers")]
    public string[] GetUsers()
    {
        return new string[] { "user1", "user2" };
    }
}