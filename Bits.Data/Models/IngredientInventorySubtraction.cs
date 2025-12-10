using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("ingredient_inventory_subtraction")]
[Index("IngredientId", Name = "ingredient_inventory_subtraction_ingredient_FK")]
[Index("BatchId", Name = "ingredient_purchased_batch_FK")]
public partial class IngredientInventorySubtraction
{
    [Key]
    [Column("ingredient_inventory_subtraction_id")]
    public int IngredientInventorySubtractionId { get; set; }

    [Column("ingredient_id")]
    public int IngredientId { get; set; }

    [Column("transaction_date", TypeName = "datetime")]
    public DateTime TransactionDate { get; set; }

    [Column("reason")]
    [StringLength(200)]
    public string Reason { get; set; } = null!;

    [Column("batch_id")]
    public int? BatchId { get; set; }

    [Column("quantity")]
    public double Quantity { get; set; }

    [ForeignKey("BatchId")]
    [InverseProperty("IngredientInventorySubtractions")]
    public virtual Batch? Batch { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("IngredientInventorySubtractions")]
    public virtual Ingredient Ingredient { get; set; } = null!;
}
