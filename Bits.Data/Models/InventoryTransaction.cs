using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("inventory_transaction")]
[Index("AccountId", Name = "inventory_transaction_account_idx")]
[Index("AppUserId", Name = "inventory_transaction_app_user_FK_idx")]
[Index("BatchId", Name = "inventory_transaction_batch_FK_idx")]
[Index("ProductContainerSizeId", Name = "inventory_transaction_product_container_size_FK_idx")]
[Index("InventoryTransctionTypeId", Name = "inventory_transaction_transaction_type_FK_idx")]
public partial class InventoryTransaction
{
    [Key]
    [Column("inventory_transaction_id")]
    public int InventoryTransactionId { get; set; }

    [Column("product_container_size_id")]
    public int ProductContainerSizeId { get; set; }

    [Column("batch_id")]
    public int BatchId { get; set; }

    [Column("inventory_transaction_date", TypeName = "datetime")]
    public DateTime InventoryTransactionDate { get; set; }

    [Column("inventory_transction_type_id")]
    public int InventoryTransctionTypeId { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("account_id")]
    public int AccountId { get; set; }

    [Column("app_user_id")]
    public int AppUserId { get; set; }

    [Column("notes")]
    [StringLength(1000)]
    public string? Notes { get; set; }

    [ForeignKey("AccountId")]
    [InverseProperty("InventoryTransactions")]
    public virtual Account Account { get; set; } = null!;

    [ForeignKey("AppUserId")]
    [InverseProperty("InventoryTransactions")]
    public virtual AppUser AppUser { get; set; } = null!;

    [ForeignKey("BatchId")]
    [InverseProperty("InventoryTransactions")]
    public virtual Batch Batch { get; set; } = null!;

    [ForeignKey("InventoryTransctionTypeId")]
    [InverseProperty("InventoryTransactions")]
    public virtual InventoryTransactionType InventoryTransctionType { get; set; } = null!;

    [ForeignKey("ProductContainerSizeId")]
    [InverseProperty("InventoryTransactions")]
    public virtual ProductContainerSize ProductContainerSize { get; set; } = null!;
}
