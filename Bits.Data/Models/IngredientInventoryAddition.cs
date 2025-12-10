using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("ingredient_inventory_addition")]
[Index("IngredientId", Name = "ingredient_inventory_addition_ingredient_FK_idx")]
[Index("SupplierId", Name = "ingredient_invertory_addition_supplier_FK_idx")]
public partial class IngredientInventoryAddition
{
    [Key]
    [Column("ingredient_inventory_addition_id")]
    public int IngredientInventoryAdditionId { get; set; }

    [Column("ingredient_id")]
    public int IngredientId { get; set; }

    [Column("order_date", TypeName = "datetime")]
    public DateTime? OrderDate { get; set; }

    [Column("estimated_delivery_date", TypeName = "datetime")]
    public DateTime? EstimatedDeliveryDate { get; set; }

    [Column("transaction_date", TypeName = "datetime")]
    public DateTime? TransactionDate { get; set; }

    [Column("supplier_id")]
    public int SupplierId { get; set; }

    [Column("quantity")]
    public double Quantity { get; set; }

    [Column("quantity_remaining")]
    public double? QuantityRemaining { get; set; }

    [Column("unit_cost")]
    [Precision(10, 2)]
    public decimal UnitCost { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("IngredientInventoryAdditions")]
    public virtual Ingredient Ingredient { get; set; } = null!;

    [ForeignKey("SupplierId")]
    [InverseProperty("IngredientInventoryAdditions")]
    public virtual Supplier Supplier { get; set; } = null!;
}
