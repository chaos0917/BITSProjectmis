using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("mash_step")]
[Index("MashId", Name = "mast_step_mash_FK_idx")]
public partial class MashStep
{
    [Key]
    [Column("mash_step_id")]
    public int MashStepId { get; set; }

    [Column("mash_id")]
    public int MashId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("version")]
    public int? Version { get; set; }

    [Column("type")]
    [StringLength(50)]
    public string? Type { get; set; }

    [Column("infuse_amount")]
    public double? InfuseAmount { get; set; }

    [Column("step_time")]
    public double? StepTime { get; set; }

    [Column("step_temp")]
    public double? StepTemp { get; set; }

    [Column("ramp_time")]
    public double? RampTime { get; set; }

    [Column("end_temp")]
    public double? EndTemp { get; set; }

    [Column("description")]
    [StringLength(1000)]
    public string? Description { get; set; }

    [Column("water_grain_ratio")]
    [StringLength(45)]
    public string? WaterGrainRatio { get; set; }

    [Column("decoction_amount")]
    [StringLength(100)]
    public string? DecoctionAmount { get; set; }

    [Column("infuse_temp")]
    [StringLength(100)]
    public string? InfuseTemp { get; set; }

    [ForeignKey("MashId")]
    [InverseProperty("MashSteps")]
    public virtual Mash Mash { get; set; } = null!;
}
