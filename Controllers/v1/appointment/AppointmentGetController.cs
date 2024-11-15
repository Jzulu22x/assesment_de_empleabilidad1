using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessmente_de_empleabilidad.Data;
using assessmente_de_empleabilidad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assessmente_de_empleabilidad.Controllers;

[ApiController]
[Route("api/appointment")]
public class AppointmentGetController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public AppointmentGetController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointments()
    {
        return await _context.Appointments.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Appointment>> GetAppointmentById(int id)
    {
        var appointment = await _context.Appointments.FindAsync(id);
        if (appointment == null)
        {
            return NotFound();
        }
        return appointment;
    }

    [HttpGet("patient/{id}")]
    public async Task<ActionResult<IEnumerable<Appointment>>> GetAppointmentsByPatientId([FromRoute] int id)
    {
        // Obtener todas las citas del paciente
        var historial = await _context.Appointments.Where(a => a.PatientId == id).ToListAsync();

        // Verificar si no hay citas
        if (!historial.Any())
        {
            return NotFound(); // Retornar 404 si no hay citas
        }

        return Ok(historial); // Retornar las citas del paciente
    }

}
