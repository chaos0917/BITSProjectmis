using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("product_container_inventory")]
public partial class ProductContainerInventory
{
    [Key]
    [Column("container_size_id")]
    public int ContainerSizeId { get; set; }

    [Column("quantity_dirty")]
    public int QuantityDirty { get; set; }

    [Column("quantity_clean")]
    public int QuantityClean { get; set; }

    [ForeignKey("ContainerSizeId")]
    [InverseProperty("ProductContainerInventory")]
    public virtual ProductContainerSize ContainerSize { get; set; } = null!;
}
