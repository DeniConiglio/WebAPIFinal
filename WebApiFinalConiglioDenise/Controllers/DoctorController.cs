using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApiFinalConiglioDenise.Data;
using WebApiFinalConiglioDenise.Models;

namespace WebApiFinalConiglioDenise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DBHospitalApiContext _context;
        public DoctorController(DBHospitalApiContext context)
        {
            _context = context;
        }



        //TRAER TODOS
        [HttpGet]
        public List<Doctor> Get()
        {
            //EF
            List<Doctor> doctores = _context.Doctores.ToList();
            return doctores;
        }


        //TRAER UNO
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            //EF
            Doctor doctor = _context.Doctores.Find(id);

            return doctor;
        }

        //INSERTAR 
        [HttpPost]
        public ActionResult Post(Doctor doctor)
        {
            //EF -- memoria
            _context.Doctores.Add(doctor);
            //EF - Guardar en la DB
            _context.SaveChanges();

            return Ok();
        }

        //MODIFICAR
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Doctor doctor)
        {
            if (id != doctor.DoctorId)
            {
                return BadRequest();
            }

            //EF para modificar en la DB
            _context.Entry(doctor).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        //Eliminar

        [HttpDelete("{id}")]
        public ActionResult<Doctor> Delete(int id)
        {
            //EF
            var profesor = _context.Doctores.Find(id);

            if (profesor == null)
            {
                return NotFound();
            }

            //EF
            _context.Doctores.Remove(profesor);
            _context.SaveChanges();

            return profesor;

        }
    }
}
