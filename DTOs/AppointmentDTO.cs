using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assessmente_de_empleabilidad.DTOs;
public class AppointmentDTO
{

    public DateTime Date { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "Reason is required")]
    [MaxLength(100, ErrorMessage = "Reason should be less than 100 characters")]
    public required string Reason { get; set; }


    [Required(ErrorMessage = "Patient ID is required")]
    public int PatientId { get; set; }

    [Required(ErrorMessage = "Doctor ID is required")]
    public int DoctorId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime? UpdatedAt { get; set; }

}
