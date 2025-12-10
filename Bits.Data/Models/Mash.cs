using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("mash")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class Mash
{
    [Key]
    [Column("mash_id")]
    public int MashId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("version")]
    public int? Version { get; set; }

    [Column("grain_temp")]
    public double? GrainTemp { get; set; }

    [Column("tun_temp")]
    public double? TunTemp { get; set; }

    [Column("sparge_temp")]
    public double? SpargeTemp { get; set; }

    [Column("ph")]
    public double? Ph { get; set; }

    [Column("tun_weight")]
    public double? TunWeight { get; set; }

    [Column("tun_specific_heat")]
    public double? TunSpecificHeat { get; set; }

    [Column("equipment_adjust")]
    public sbyte? EquipmentAdjust { get; set; }

    [Column("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }

    [InverseProperty("Mash")]
    public virtual ICollection<MashStep> MashSteps { get; set; } = new List<MashStep>();

    [InverseProperty("Mash")]
    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
