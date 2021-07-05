using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using ParksAPI.Models;

namespace ParksAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksAPIContext _db;

    public ParksController(ParksAPIContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string location, string type)
    {
      var query = _db.Parks.AsQueryable();

      if(name != null)
      {
        query = query.Where(entry => entry.ParkName == name);
      }

      if(location != null)
      {
        query = query.Where(entry => entry.ParkLocation == location);
      }

      if(type != null)
      {
        query = query.Where(entry => entry.ParkType == type);
      }

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if(park == null)
      {
        return NotFound();
      }
      return park;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if(id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if(!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if(park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }
  }
}