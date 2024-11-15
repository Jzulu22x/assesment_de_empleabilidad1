using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessmente_de_empleabilidad.Data;
using Microsoft.AspNetCore.Mvc;

namespace assessmente_de_empleabilidad.Controllers.v1.appointment
{
    [ApiController]
    [Route("api/appointment")]
    public class AppointmentDeleteController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public AppointmentDeleteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpDelete("appointment/{id}")]
        public async Task<IActionResult> DeleteAppointment([FromRoute] int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);

            if (appointment == null)
            {
                return NotFound();
            }

            _context.Appointments.Remove(appointment);


            await _context.SaveChangesAsync();


            return NoContent();
        }
    }
}