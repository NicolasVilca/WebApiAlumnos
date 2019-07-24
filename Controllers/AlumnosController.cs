using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapialumnos.Models;

namespace webapialumnos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        public static List<Alumno> Alumnos { get; set; } = new List<Alumno>()
        {
            // id, nombre, apellido, edad, especialidad
            new Alumno(0, "Andres", "Montilla", 18, "Tecnologia"),
            new Alumno(1, "Fernando", "Nizz", 18, "Tecnologia"),
            new Alumno(2, "Nicolas", "Vilca", 18, "Tecnologia")       
        };

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Alumno>> Get()
        {
            return Alumnos.OrderBy(p => p.id).ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            for (int i = 0; i < Alumnos.Count; i++)
            {
                if (Alumnos[i].id == id)
                {
                    return Alumnos[i];
                }
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Alumno value)
        {
            int maxID = Alumnos[(Alumnos.Count)-1].id;
            if (Alumnos.Count != 0)
            {
                value.id = maxID + 1;                
            }
            Alumnos.Add(value);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Alumno value)
        {
            for (int i = 0; i < Alumnos.Count; i++)
            {
                if (Alumnos[i].id == id)
                {
                    int idAnterior = Alumnos[i].id;
                    Alumnos[id]=value;
                    Alumnos[id].id=idAnterior;
                    return Ok();
                }
            }
            return NotFound();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
             for (int i = 0; i < Alumnos.Count; i++)
            {
                if (Alumnos[i].id == id)
                {
                    Alumnos.RemoveAt(id);
                    return Ok();
                }
            }
            return NotFound();
        }
    }
}
