using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessmente_de_empleabilidad.Data;
using assessmente_de_empleabilidad.DTOs;
using assessmente_de_empleabilidad.Models;
using Microsoft.AspNetCore.Mvc;

namespace assessmente_de_empleabilidad.Controllers.v1.patient;

[ApiController]
[Route("api/patient")]
public class PatientPostController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public PatientPostController(ApplicationDbContext context)
    {
        _context = context;
    }

    //Crear un paciente con el DTO
    [HttpPost]
    public async Task<ActionResult<Patient>> CreatePatient(PatientDTO patient)
    {
        var newPatient = new Patient
        {
            FirstName = patient.FirstName,
            LastName = patient.LastName,
            Email = patient.Email,
            UserName = patient.UserName,
            RoleId = 3
        };
        
        _context.Patients.Add(newPatient);
        await _context.SaveChangesAsync();
        
        return Ok();   
    }
}
