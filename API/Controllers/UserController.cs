using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(DataContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() 
    {
        return Ok(await context.Users.ToListAsync());
    }

    [HttpGet("wow{id:int}wow")]
    public async Task<ActionResult<AppUser>> GetUser(int id) 
    {
        return Ok(await context.Users.FindAsync(id));
    }
}