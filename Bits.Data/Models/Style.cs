using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("style")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class Style
{
    [Key]
    [Column("style_id")]
    public int StyleId { get; set; }

    [Column("name")]
    [StringLength(200)]
    public string Name { get; set; } = null!;

    [Column("version")]
    public int? Version { get; set; }

    [Column("category_name")]
    [StringLength(50)]
    public string? CategoryName { get; set; }

    [Column("category_number")]
    [StringLength(50)]
    public string? CategoryNumber { get; set; }

    [Column("category_letter")]
    [StringLength(50)]
    public string? CategoryLetter { get; set; }

    [Column("style_guide")]
    [StringLength(50)]
    public string? StyleGuide { get; set; }

    [Column("type")]
    [StringLength(50)]
    public string? Type { get; set; }

    [Column("og_min")]
    public double? OgMin { get; set; }

    [Column("og_max")]
    public double? OgMax { get; set; }

    [Column("fg_min")]
    public double? FgMin { get; set; }

    [Column("fg_max")]
    public double? FgMax { get; set; }

    [Column("ibu_min")]
    public double? IbuMin { get; set; }

    [Column("ibu_max")]
    public double? IbuMax { get; set; }

    [Column("color_min")]
    public double? ColorMin { get; set; }

    [Column("color_max")]
    public double? ColorMax { get; set; }

    [Column("carb_min")]
    public double? CarbMin { get; set; }

    [Column("carb_max")]
    public double? CarbMax { get; set; }

    [Column("abv_min")]
    public double? AbvMin { get; set; }

    [Column("abv_max")]
    public double? AbvMax { get; set; }

    [Column("notes")]
    [StringLength(5000)]
    public string? Notes { get; set; }

    [Column("profile")]
    [StringLength(5000)]
    public string? Profile { get; set; }

    [Column("ingredients")]
    [StringLength(2000)]
    public string? Ingredients { get; set; }

    [Column("examples")]
    [StringLength(2000)]
    public string? Examples { get; set; }

    [InverseProperty("Style")]
    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    [ForeignKey("StyleId")]
    [InverseProperty("Styles")]
    public virtual ICollection<Ingredient> IngredientsNavigation { get; set; } = new List<Ingredient>();
}
