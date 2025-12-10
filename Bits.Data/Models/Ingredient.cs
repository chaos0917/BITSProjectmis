using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("ingredient")]
[Index("IngredientTypeId", Name = "ingredient_ingredient_type_FK_idx")]
[Index("UnitTypeId", Name = "ingredient_unit_type_FK_idx")]
public partial class Ingredient
{
    [Key]
    [Column("ingredient_id")]
    public int IngredientId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("version")]
    public int? Version { get; set; }

    [Column("ingredient_type_id")]
    public int IngredientTypeId { get; set; }

    [Column("on_hand_quantity")]
    public double OnHandQuantity { get; set; }

    [Column("unit_type_id")]
    public int UnitTypeId { get; set; }

    [Column("unit_cost")]
    [Precision(10, 2)]
    public decimal UnitCost { get; set; }

    [Column("reorder_point")]
    public double ReorderPoint { get; set; }

    [Column("notes")]
    [StringLength(2000)]
    public string? Notes { get; set; }

    [InverseProperty("Ingredient")]
    public virtual Adjunct? Adjunct { get; set; }

    [InverseProperty("Ingredient")]
    public virtual Fermentable? Fermentable { get; set; }

    [InverseProperty("Ingredient")]
    public virtual Hop? Hop { get; set; }

    [InverseProperty("Ingredient")]
    public virtual ICollection<IngredientInventoryAddition> IngredientInventoryAdditions { get; set; } = new List<IngredientInventoryAddition>();

    [InverseProperty("Ingredient")]
    public virtual ICollection<IngredientInventorySubtraction> IngredientInventorySubtractions { get; set; } = new List<IngredientInventorySubtraction>();

    [ForeignKey("IngredientTypeId")]
    [InverseProperty("Ingredients")]
    public virtual IngredientType IngredientType { get; set; } = null!;

    [InverseProperty("Ingredient")]
    public virtual ICollection<RecipeIngredient> RecipeIngredients { get; set; } = new List<RecipeIngredient>();

    [ForeignKey("UnitTypeId")]
    [InverseProperty("Ingredients")]
    public virtual UnitType UnitType { get; set; } = null!;

    [InverseProperty("Ingredient")]
    public virtual Yeast? Yeast { get; set; }

    [ForeignKey("SubstituteIngredientId")]
    [InverseProperty("SubstituteIngredients")]
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    [ForeignKey("IngredientId")]
    [InverseProperty("IngredientsNavigation")]
    public virtual ICollection<Style> Styles { get; set; } = new List<Style>();

    [ForeignKey("IngredientId")]
    [InverseProperty("Ingredients")]
    public virtual ICollection<Ingredient> SubstituteIngredients { get; set; } = new List<Ingredient>();
}
