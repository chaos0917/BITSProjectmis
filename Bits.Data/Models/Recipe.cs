using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("recipe")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
[Index("EquipmentId", Name = "recipe_equipment_FK_idx")]
[Index("MashId", Name = "recipe_mash_FK_idx")]
[Index("StyleId", Name = "recipe_style_type_FK_idx")]
public partial class Recipe
{
    [Key]
    [Column("recipe_id")]
    public int RecipeId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("version")]
    public int? Version { get; set; }

    [Column("date", TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [Column("style_id")]
    public int StyleId { get; set; }

    [Column("volume")]
    public double Volume { get; set; }

    [Column("brewer")]
    [StringLength(100)]
    public string Brewer { get; set; } = null!;

    [Column("boil_time")]
    public double? BoilTime { get; set; }

    [Column("boil_volume")]
    public double? BoilVolume { get; set; }

    [Column("efficiency")]
    public double? Efficiency { get; set; }

    [Column("fermentation_stages")]
    public int? FermentationStages { get; set; }

    [Column("estimated_og")]
    public double? EstimatedOg { get; set; }

    [Column("estimated_fg")]
    public double? EstimatedFg { get; set; }

    [Column("estimated_color")]
    public double? EstimatedColor { get; set; }

    [Column("estimated_abv")]
    public double? EstimatedAbv { get; set; }

    [Column("actual_efficiency")]
    public double? ActualEfficiency { get; set; }

    [Column("equipment_id")]
    public int? EquipmentId { get; set; }

    [Column("carbonation_used")]
    [StringLength(100)]
    public string? CarbonationUsed { get; set; }

    [Column("forced_carbonation")]
    public sbyte? ForcedCarbonation { get; set; }

    [Column("keg_priming_factor")]
    public double? KegPrimingFactor { get; set; }

    [Column("carbonation_temp")]
    public double? CarbonationTemp { get; set; }

    [Column("mash_id")]
    public int? MashId { get; set; }

    [InverseProperty("Recipe")]
    public virtual ICollection<Batch> Batches { get; set; } = new List<Batch>();

    [ForeignKey("EquipmentId")]
    [InverseProperty("Recipes")]
    public virtual Equipment? Equipment { get; set; }

    [ForeignKey("MashId")]
    [InverseProperty("Recipes")]
    public virtual Mash? Mash { get; set; }

    [InverseProperty("Recipe")]
    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

    [ForeignKey("StyleId")]
    [InverseProperty("Recipes")]
    public virtual Style Style { get; set; } = null!;
}
