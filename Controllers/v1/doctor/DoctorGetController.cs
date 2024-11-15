using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessmente_de_empleabilidad.Data;
using assessmente_de_empleabilidad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assessmente_de_empleabilidad.Controllers.v1.doctor;

[ApiController]
[Route("api/doctor")]
public class DoctorGetController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public DoctorGetController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Doctor>>> GetDoctors()
    {
        return await _context.Doctors.ToListAsync();
    }

    [HttpGet("available")]
    public async Task<ActionResult<IEnumerable<Doctor>>> GetAvailableDoctors()
    {
        return await _context.Doctors.Where(d => d.Availability == true).ToListAsync();
    }

    [HttpGet("unavailable")]
    public async Task<ActionResult<IEnumerable<Doctor>>> GetUnavailableDoctors()
    {
        return await _context.Doctors.Where(d => d.Availability != true).ToListAsync();
    }
}
