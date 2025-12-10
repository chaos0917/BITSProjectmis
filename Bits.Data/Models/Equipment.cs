using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("equipment")]
[Index("Name", Name = "equipment_name_UNIQUE", IsUnique = true)]
public partial class Equipment
{
    [Key]
    [Column("equipment_id")]
    public int EquipmentId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("version")]
    public int? Version { get; set; }

    [Column("boil_size")]
    public double? BoilSize { get; set; }

    [Column("batch_size")]
    public double? BatchSize { get; set; }

    [Column("tun_volume")]
    public double? TunVolume { get; set; }

    [Column("tun_weight")]
    public double? TunWeight { get; set; }

    [Column("tun_specific_heat")]
    public double? TunSpecificHeat { get; set; }

    [Column("top_up_water")]
    public double? TopUpWater { get; set; }

    [Column("trub_chiller_loss")]
    public double? TrubChillerLoss { get; set; }

    [Column("evap_rate")]
    public double? EvapRate { get; set; }

    [Column("boil_time")]
    public double? BoilTime { get; set; }

    [Column("calc_boil_volume")]
    public sbyte? CalcBoilVolume { get; set; }

    [Column("lauter_deadspace")]
    public double? LauterDeadspace { get; set; }

    [Column("top_up_kettle")]
    public double? TopUpKettle { get; set; }

    [Column("hop_utilization")]
    public double? HopUtilization { get; set; }

    [Column("cooling_loss_pct")]
    public double? CoolingLossPct { get; set; }

    [Column("notes")]
    [StringLength(1000)]
    public string? Notes { get; set; }

    [InverseProperty("Equipment")]
    public virtual ICollection<Batch> Batches { get; set; } = new List<Batch>();

    [InverseProperty("Equipment")]
    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
