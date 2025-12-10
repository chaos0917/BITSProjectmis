using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("recipe_ingredient")]
[Index("IngredientId", Name = "recipe_ingredient_ingredient_idx")]
[Index("RecipeId", Name = "recipe_ingredient_recipe_FK")]
[Index("UseDuringId", Name = "recipe_ingredient_use_during_FK_idx")]
public partial class RecipeIngredient
{
    [Key]
    [Column("recipe_ingredient_id")]
    public int RecipeIngredientId { get; set; }

    [Column("recipe_id")]
    public int RecipeId { get; set; }

    [Column("ingredient_id")]
    public int IngredientId { get; set; }

    [Column("quantity")]
    public double Quantity { get; set; }

    [Column("time")]
    public double? Time { get; set; }

    [Column("use_during_id")]
    public int? UseDuringId { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("RecipeIngredients")]
    public virtual Ingredient Ingredient { get; set; } = null!;

    [ForeignKey("RecipeId")]
    [InverseProperty("RecipeIngredients")]
    public virtual Recipe Recipe { get; set; } = null!;

    [ForeignKey("UseDuringId")]
    [InverseProperty("RecipeIngredients")]
    public virtual UseDuring? UseDuring { get; set; }
}
