using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReceptAPI.Models;

namespace ReceptAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HozzavaloController : ControllerBase
    {
        [HttpGet("All")]
        public IActionResult GetAllHozzavalo()
        {
            using(var context = new ReceptdbContext())
            {
                try
                {
                    var lista = context.Hozzavalos.ToList();
                    return Ok(lista);

                } catch(Exception ex)
                {
                    return BadRequest($"Hiba az adatok betöltése során: {ex.Message}");
                }
            }
        }

        [HttpPost("Uj")]
        public async Task<IActionResult> UjHozzavalo(Hozzavalo hozzavalo)
        {
            using(var context = new ReceptdbContext())
            {
                try
                {
                    await context.AddAsync(hozzavalo);
                    await context.SaveChangesAsync();
                    return Ok("Sikeres mentés!");

                } catch(Exception ex)
                {
                    return BadRequest($"Sikertelen feltöltés: {ex.Message}");
                }
            }
        }


    }
}
