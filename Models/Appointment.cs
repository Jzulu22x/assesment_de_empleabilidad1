using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assessmente_de_empleabilidad.Models;

[Table("appointments")]
public class Appointment
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("date")]
    public DateTime Date { get; set; }

    [Column("time")]
    public required string Time { get; set; }

    [Column("reason")]
    [Required(ErrorMessage = "Reason is required")]
    [MaxLength(100, ErrorMessage = "Reason should be less than 100 characters")]
    public required string Reason { get; set; }

    [Column("patient_id")]
    [Required(ErrorMessage = "Patient ID is required")]
    public int PatientId { get; set; }

    [Column("doctor_id")]
    [Required(ErrorMessage = "Doctor ID is required")]
    public int DoctorId { get; set; }
    
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    [Column("updated_at")]
    public DateTime? UpdatedAt { get; set; }


    [ForeignKey("patient_id")]
    public Patient? Patient { get; set; }

    [ForeignKey("doctor_id")]
    public Doctor? Doctor { get; set; }

}