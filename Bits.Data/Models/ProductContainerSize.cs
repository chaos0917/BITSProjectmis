using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("product_container_size")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class ProductContainerSize
{
    [Key]
    [Column("container_size_id")]
    public int ContainerSizeId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("volume")]
    public double Volume { get; set; }

    [Column("item_quantity")]
    public int ItemQuantity { get; set; }

    [InverseProperty("ProductContainerSize")]
    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();

    [InverseProperty("ContainerSize")]
    public virtual ProductContainerInventory? ProductContainerInventory { get; set; }

    [InverseProperty("ProductContainerSize")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
