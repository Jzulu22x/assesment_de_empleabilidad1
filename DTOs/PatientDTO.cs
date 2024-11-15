using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assessmente_de_empleabilidad.DTOs;
public class PatientDTO
{
    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Email { get; set; }

    public int RoleId { get; set; }

    public required string UserName { get; set; }
}
