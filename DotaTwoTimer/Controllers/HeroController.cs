using System.Security.Claims;
using DAL.DbModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace DotaTwoTimer.Controllers;

public class HeroController : Controller
{
    private readonly DefaultDbContext _context;

    public HeroController(DefaultDbContext context)
    {
        _context = context;
    }
    
    [HttpGet]
    [Route("GetAllHeroes")]
    [SwaggerOperation(Summary = "Get all heroes")]
    public async Task<IActionResult> GetAllHeroes()
    {

        var heroes = await _context.Heroes.Where(x=> true).Include(z=> z.Abilities).ToListAsync();
        return Ok(heroes);
    }
}