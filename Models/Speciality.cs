using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assessmente_de_empleabilidad.Models;

[Table("specialities")]
public class Speciality
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
     public int Id { get; set; }  // Primary Key

    [Column("name")]
    public required string Name { get; set; }
}
