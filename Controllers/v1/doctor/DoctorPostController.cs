using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessmente_de_empleabilidad.Data;
using assessmente_de_empleabilidad.DTOs;
using assessmente_de_empleabilidad.Models;
using Microsoft.AspNetCore.Mvc;

namespace assessmente_de_empleabilidad.Controllers.v1.doctor;

[ApiController]
[Route("api/doctor")]
public class DoctorPostController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public DoctorPostController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<Doctor>> CreateDoctor([FromBody] DoctorDTO doctor)
    {
        var newDoctor = new Doctor
        {
            FirstName = doctor.FirstName,
            LastName = doctor.LastName,
            Availability = doctor.Availability,
            UserName = doctor.UserName,
            Email = doctor.Email,
            RoleId =  doctor.RoleId,
            SpecialtyId = doctor.SpecialityId
        };

        _context.Doctors.Add(newDoctor);
        await _context.SaveChangesAsync();
        return Ok(doctor);
    }
}
