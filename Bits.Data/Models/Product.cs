using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[PrimaryKey("BatchId", "ProductContainerSizeId")]
[Table("product")]
[Index("BatchId", Name = "keg_batch_FK_idx")]
[Index("ProductContainerSizeId", Name = "product_product_container_size_FK")]
public partial class Product
{
    [Key]
    [Column("batch_id")]
    public int BatchId { get; set; }

    [Key]
    [Column("product_container_size_id")]
    public int ProductContainerSizeId { get; set; }

    [Column("racked_date", TypeName = "datetime")]
    public DateTime RackedDate { get; set; }

    [Column("sell_by_date", TypeName = "datetime")]
    public DateTime SellByDate { get; set; }

    [Column("quantity_racked")]
    public int QuantityRacked { get; set; }

    [Column("quantity_remaining")]
    public int QuantityRemaining { get; set; }

    [Column("ingredient_cost")]
    [Precision(10, 4)]
    public decimal? IngredientCost { get; set; }

    [Column("suggested_price")]
    [Precision(10, 4)]
    public decimal? SuggestedPrice { get; set; }

    [ForeignKey("BatchId")]
    [InverseProperty("Products")]
    public virtual Batch Batch { get; set; } = null!;

    [ForeignKey("ProductContainerSizeId")]
    [InverseProperty("Products")]
    public virtual ProductContainerSize ProductContainerSize { get; set; } = null!;
}
