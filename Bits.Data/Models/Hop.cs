using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("hop")]
[Index("HopTypeId", Name = "hop_hop_type_idx")]
public partial class Hop
{
    [Key]
    [Column("ingredient_id")]
    public int IngredientId { get; set; }

    [Column("hop_type_id")]
    public int? HopTypeId { get; set; }

    [Column("origin")]
    [StringLength(50)]
    public string? Origin { get; set; }

    [Column("alpha")]
    public double? Alpha { get; set; }

    [Column("beta")]
    public double? Beta { get; set; }

    [Column("hsi")]
    public double? Hsi { get; set; }

    [Column("form")]
    [StringLength(50)]
    public string? Form { get; set; }

    [ForeignKey("HopTypeId")]
    [InverseProperty("Hops")]
    public virtual HopType? HopType { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("Hop")]
    public virtual Ingredient Ingredient { get; set; } = null!;
}
