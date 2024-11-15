using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assessmente_de_empleabilidad.Models;

[Table("admins")]
public class Admin
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("user_name")]
    public required string UserName { get; set; }

    [Column("password")]
    public required string Password { get; set; }

    [Column("name")]
    public required string Name { get; set; }

    [Column("role_id")]
    public int RoleId { get; set; }

    [ForeignKey("RoleId")]
    public Role? Role { get; set; }
}
