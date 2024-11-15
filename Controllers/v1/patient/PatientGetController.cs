using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessmente_de_empleabilidad.Data;
using assessmente_de_empleabilidad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace assessmente_de_empleabilidad.Controllers.v1.patient;

[ApiController]
[Route("api/patient")]
public class PatientGetController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PatientGetController(ApplicationDbContext context)
    {
        _context = context;
    }


    [HttpGet]
    public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
    {
        return await _context.Patients.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Patient>> GetPatient(int id)
    {
        var patient = await _context.Patients.FindAsync(id);
        
        if (patient == null)
        {
            return NotFound();
        }
        
        return patient;
    }

    //obtener histotial de citas 
}
