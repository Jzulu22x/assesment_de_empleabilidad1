using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessmente_de_empleabilidad.Data;
using assessmente_de_empleabilidad.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace assessmente_de_empleabilidad.Controllers.v1.appointment;

[ApiController]
[Route("api/appointment")]
public class AppointmentPutController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AppointmentPutController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPut("{id}")]
public async Task<IActionResult> UpdateAppointment([FromRoute] int id, [FromBody] AppointmentDTO appointment)
{
    // Buscar la cita en la base de datos usando el id proporcionado en la ruta
    var appointmentInDb = await _context.Appointments.FindAsync(id);

    if (appointmentInDb == null)
    {
        return NotFound(); // Si no se encuentra la cita, retornar 404
    }

    // Actualizar los campos de la cita con los nuevos valores
    appointmentInDb.DoctorId = appointment.DoctorId;
    appointmentInDb.PatientId = appointment.PatientId;
    appointmentInDb.Reason = appointment.Reason;
    appointmentInDb.UpdatedAt = DateTime.UtcNow; // Se actualiza la fecha de modificación

    // Guardar los cambios en la base de datos
    await _context.SaveChangesAsync();

    return Ok(appointmentInDb); // Retornar la cita actualizada
}


}
