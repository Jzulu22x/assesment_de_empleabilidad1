using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assessmente_de_empleabilidad.Models;

[Table("doctors")]
public class Doctor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }  // Primary Key

    [Column("first_name")]
    public required string FirstName { get; set; }

    [Column("last_name")]
    public required string LastName { get; set; }

    [Column("availability")]
    public required bool Availability { get; set; }

    [Column("specialty_id")]
    public required int SpecialtyId { get; set; } 

    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("user_name")]
    public required string UserName { get; set; }

    [Column("email")]
    public required string Email { get; set; }

    [ForeignKey("SpecialtyId")]
    public Speciality? Speciality {get; set; }

    [ForeignKey("RoleId")]
    public Role? Role { get; set; }
}
