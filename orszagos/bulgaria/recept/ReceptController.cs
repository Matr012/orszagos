using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReceptAPI.DTO;
using ReceptAPI.Models;

namespace ReceptAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptController : ControllerBase
    {

        [HttpGet("ById/{id}")]
        public IActionResult GetReceptById(int id)
        {
            using (var context = new ReceptdbContext())
            {
                try
                {
                    var keresett = context.Recepts.Include(s => s.Szakacs).Include(n => n.Nehezseg).Where(i => i.Id == id).Select(d => new ReceptIdDTO()
                    {
                        Nev = d.Nev,
                        Szint = d.Nehezseg.Szint,
                        ElkeszitesiIdo = d.ElkeszitesiIdo,
                        SzakacsNev = d.Szakacs.Nev
                    }).FirstOrDefault();

                    if (keresett != null)
                    {
                        return Ok(keresett);
                    }
                    else
                    {
                        return NotFound($"Nincs recept a megadott ID-val: {id}");
                    }


                } catch(Exception ex)
                {
                    return BadRequest($"Hiba a lekérdezés során: {ex.Message}");
                }
            }
        }
    }
}
