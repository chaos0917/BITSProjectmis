using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("adjunct")]
[Index("AdjunctTypeId", Name = "adjunct_adjunct_type_FK_idx")]
[Index("RecommendedUseDuringId", Name = "adjunct_use_during_FK_idx")]
public partial class Adjunct
{
    [Key]
    [Column("ingredient_id")]
    public int IngredientId { get; set; }

    [Column("adjunct_type_id")]
    public int AdjunctTypeId { get; set; }

    [Column("use_for")]
    [StringLength(200)]
    public string? UseFor { get; set; }

    [Column("recommended_quantity")]
    public double? RecommendedQuantity { get; set; }

    [Column("batch_volume")]
    public double? BatchVolume { get; set; }

    [Column("recommended_use_during_id")]
    public int? RecommendedUseDuringId { get; set; }

    [ForeignKey("AdjunctTypeId")]
    [InverseProperty("Adjuncts")]
    public virtual AdjunctType AdjunctType { get; set; } = null!;

    [ForeignKey("IngredientId")]
    [InverseProperty("Adjunct")]
    public virtual Ingredient Ingredient { get; set; } = null!;

    [ForeignKey("RecommendedUseDuringId")]
    [InverseProperty("Adjuncts")]
    public virtual UseDuring? RecommendedUseDuring { get; set; }
}
