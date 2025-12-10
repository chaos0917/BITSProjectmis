using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("batch")]
[Index("RecipeId", Name = "batch_recipe_FK")]
[Index("EquipmentId", Name = "batch_recipe_FK_idx")]
public partial class Batch
{
    [Key]
    [Column("batch_id")]
    public int BatchId { get; set; }

    [Column("recipe_id")]
    public int RecipeId { get; set; }

    [Column("equipment_id")]
    public int EquipmentId { get; set; }

    [Column("volume")]
    public double Volume { get; set; }

    [Column("scheduled_start_date", TypeName = "datetime")]
    public DateTime? ScheduledStartDate { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("estimated_finish_date", TypeName = "datetime")]
    public DateTime? EstimatedFinishDate { get; set; }

    [Column("finish_date", TypeName = "datetime")]
    public DateTime? FinishDate { get; set; }

    [Column("unit_cost")]
    [Precision(10, 2)]
    public decimal? UnitCost { get; set; }

    [Column("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }

    [Column("taste_notes")]
    [StringLength(2000)]
    public string? TasteNotes { get; set; }

    [Column("taste_rating")]
    public double? TasteRating { get; set; }

    [Column("og")]
    public double? Og { get; set; }

    [Column("fg")]
    public double? Fg { get; set; }

    [Column("carbonation")]
    public double? Carbonation { get; set; }

    [Column("fermentation_stages")]
    public int? FermentationStages { get; set; }

    [Column("primary_age")]
    public double? PrimaryAge { get; set; }

    [Column("primary_temp")]
    public double? PrimaryTemp { get; set; }

    [Column("secondary_age")]
    public double? SecondaryAge { get; set; }

    [Column("secondary_temp")]
    public double? SecondaryTemp { get; set; }

    [Column("tertiary_age")]
    public double? TertiaryAge { get; set; }

    [Column("age")]
    public double? Age { get; set; }

    [Column("temp")]
    public double? Temp { get; set; }

    [Column("ibu")]
    public double? Ibu { get; set; }

    [Column("ibu_method")]
    [StringLength(50)]
    public string? IbuMethod { get; set; }

    [Column("abv")]
    public double? Abv { get; set; }

    [Column("actual_efficiency")]
    public double? ActualEfficiency { get; set; }

    [Column("calories")]
    public double? Calories { get; set; }

    [Column("carbonation_used")]
    [StringLength(100)]
    public string? CarbonationUsed { get; set; }

    [Column("forced_carbonation")]
    public sbyte? ForcedCarbonation { get; set; }

    [Column("keg_priming_factor")]
    public double? KegPrimingFactor { get; set; }

    [Column("carbonation_temp")]
    public double? CarbonationTemp { get; set; }

    [InverseProperty("Batch")]
    public virtual ICollection<BatchContainer> BatchContainers { get; set; } = new List<BatchContainer>();

    [ForeignKey("EquipmentId")]
    [InverseProperty("Batches")]
    public virtual Equipment Equipment { get; set; } = null!;

    [InverseProperty("Batch")]
    public virtual ICollection<IngredientInventorySubtraction> IngredientInventorySubtractions { get; set; } = new List<IngredientInventorySubtraction>();

    [InverseProperty("Batch")]
    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();

    [InverseProperty("Batch")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    [ForeignKey("RecipeId")]
    [InverseProperty("Batches")]
    public virtual Recipe Recipe { get; set; } = null!;
}
