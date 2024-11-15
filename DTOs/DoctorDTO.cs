using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assessmente_de_empleabilidad.DTOs;
public class DoctorDTO
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public bool Availability { get; set; } = true;
    public string UserName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public int SpecialityId { get; set; } 
    public int RoleId { get; set; } 
}