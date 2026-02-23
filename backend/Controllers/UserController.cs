using Microsoft.AspNetCore.Mvc;
using backend.Models;
using backend.Services;
using backend.Services.Interface;

namespace backend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserService service) : ControllerBase
{
  [HttpGet]
  public async Task<ActionResult<List<Users>>> GetAllUSers()
    => Ok(await service.GetAllUsersAsync());

  [HttpGet("{id}")]
  public async Task<ActionResult<Users>> GetUserById(int id)
  {
    var user = await service.GetUserByIdAsync(id);
    return user is null ?
      NotFound("User not found") :
      Ok(user);
  }
}
