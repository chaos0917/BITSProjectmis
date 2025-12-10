using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("yeast")]
public partial class Yeast
{
    [Key]
    [Column("ingredient_id")]
    public int IngredientId { get; set; }

    [Column("product_id")]
    [StringLength(50)]
    public string? ProductId { get; set; }

    [Column("min_temp")]
    public double? MinTemp { get; set; }

    [Column("max_temp")]
    public double? MaxTemp { get; set; }

    [Column("form")]
    [StringLength(50)]
    public string? Form { get; set; }

    [Column("laboratory")]
    [StringLength(50)]
    public string? Laboratory { get; set; }

    [Column("flocculation")]
    [StringLength(50)]
    public string? Flocculation { get; set; }

    [Column("attenuation")]
    public double? Attenuation { get; set; }

    [Column("max_reuse")]
    public int? MaxReuse { get; set; }

    [Column("add_to_secondary")]
    public sbyte? AddToSecondary { get; set; }

    [Column("type")]
    [StringLength(50)]
    public string? Type { get; set; }

    [Column("best_for")]
    [StringLength(500)]
    public string? BestFor { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("Yeast")]
    public virtual Ingredient Ingredient { get; set; } = null!;
}
