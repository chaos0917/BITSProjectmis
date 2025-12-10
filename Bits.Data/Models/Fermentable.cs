using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("fermentable")]
[Index("FermentableTypeId", Name = "fermentable_fermentable_type_FK_idx")]
public partial class Fermentable
{
    [Key]
    [Column("ingredient_id")]
    public int IngredientId { get; set; }

    [Column("fermentable_type_id")]
    public int? FermentableTypeId { get; set; }

    [Column("color")]
    public double? Color { get; set; }

    [Column("yield")]
    public double? Yield { get; set; }

    [Column("origin")]
    [StringLength(50)]
    public string? Origin { get; set; }

    [Column("coarse_fine_diff")]
    public double? CoarseFineDiff { get; set; }

    [Column("moisture")]
    public double? Moisture { get; set; }

    [Column("diastatic_power")]
    public double? DiastaticPower { get; set; }

    [Column("protein")]
    public double? Protein { get; set; }

    [Column("max_in_batch")]
    public double? MaxInBatch { get; set; }

    [Column("recommend_mash")]
    public sbyte? RecommendMash { get; set; }

    [Column("add_after_boil")]
    public sbyte? AddAfterBoil { get; set; }

    [Column("ibu_gal_per_lb")]
    public double? IbuGalPerLb { get; set; }

    [Column("potential")]
    public double? Potential { get; set; }

    [ForeignKey("FermentableTypeId")]
    [InverseProperty("Fermentables")]
    public virtual FermentableType? FermentableType { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("Fermentable")]
    public virtual Ingredient Ingredient { get; set; } = null!;
}
