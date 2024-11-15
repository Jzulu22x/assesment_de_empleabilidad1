using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessmente_de_empleabilidad.Data;
using assessmente_de_empleabilidad.DTOs;
using assessmente_de_empleabilidad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assessmente_de_empleabilidad.Controllers.v1.appointment;

[ApiController]
[Route("api/appointment")]
public class AppointmentPostController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AppointmentPostController(ApplicationDbContext context)
    {
        _context = context;
    }

   [HttpPost]
public async Task<IActionResult> Post([FromBody] AppointmentDTO appointment)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

    // Verificar si ya existe una cita con la misma fecha y hora
    var existingAppointment = await _context.Appointments
        .FirstOrDefaultAsync(a => a.Date == appointment.Date);

    if (existingAppointment != null)
    {
        return BadRequest("Ya existe una cita en el mismo horario.");
    }

    // Si no hay conflictos, agregar la nueva cita
    var newAppointment = new Appointment
    {
        Date = appointment.Date,
        Reason = appointment.Reason,
    };

    _context.Appointments.Add(newAppointment);
    await _context.SaveChangesAsync();

    return Ok("Cita agregada con éxito.");
}


}

