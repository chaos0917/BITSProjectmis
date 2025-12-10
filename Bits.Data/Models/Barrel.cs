using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("barrel")]
public partial class Barrel
{
    [Key]
    [Column("brew_container_id")]
    public int BrewContainerId { get; set; }

    [Column("treatment")]
    [StringLength(50)]
    public string Treatment { get; set; } = null!;

    [ForeignKey("BrewContainerId")]
    [InverseProperty("Barrel")]
    public virtual BrewContainer BrewContainer { get; set; } = null!;
}
