using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReceptAPI.Models;

namespace ReceptAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SzakacsController : ControllerBase
    {

        [HttpPut("Modosit")]
        public async Task<IActionResult> ModositSzakacs(Szakac szakacs)
        {
            using(var context = new ReceptdbContext())
            {
                try
                {
                    if (context.Szakacs.Any(s => s.Id == szakacs.Id))
                    {
                        context.Update(szakacs);
                        await context.SaveChangesAsync();
                        return Ok("Sikeres módosítás");
                    }
                    else
                    {
                        return NotFound("Nem azonosítható szakács");
                    }


                } catch (Exception ex)
                {
                    return BadRequest($"Sikertelen módosítás: {ex.Message}");
                }
            }
        }

        [HttpDelete("Torol/{id}")]
        public async Task<IActionResult> TorolSzakacs(int id)
        {
            using(var context = new ReceptdbContext())
            {
                try
                {
                    if (context.Szakacs.Any(s => s.Id == id))
                    {
                        context.Remove(new Szakac() { Id = id });
                        await context.SaveChangesAsync();
                        return Ok("Sikeres törlés");
                    }
                    else
                    {
                        return NotFound("Nincs azonosítható szakács!");
                    }

                } catch (Exception ex)
                {
                    return BadRequest($"Hiba a törlés során: {ex.Message}");
                }
            }
        }
    }
}
