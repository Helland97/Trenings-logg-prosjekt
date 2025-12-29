using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trenings_logg_prosjekt.Backend.Data;
using Trenings_logg_prosjekt.Backend.Models;


namespace Trenings_logg_prosjekt.Backend.Controllers;


[ApiController]
[Route("api/[controller]")]
public class WorkoutsController : ControllerBase
{
    private readonly AppDbContext _db;

    public WorkoutsController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var workouts = await _db.Workouts.ToListAsync();
        return Ok(workouts);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Workout workout)
    {
        _db.Workouts.Add(workout);
        await _db.SaveChangesAsync();
        return Ok(workout);
    }
}
