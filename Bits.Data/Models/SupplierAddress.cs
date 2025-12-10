using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[PrimaryKey("SupplierId", "AddressId", "AddressTypeId")]
[Table("supplier_address")]
[Index("AddressId", Name = "supplier_address_address_FK_idx")]
[Index("AddressTypeId", Name = "supplier_address_address_type_FK_idx")]
public partial class SupplierAddress
{
    [Key]
    [Column("supplier_id")]
    public int SupplierId { get; set; }

    [Key]
    [Column("address_id")]
    public int AddressId { get; set; }

    [Key]
    [Column("address_type_id")]
    public int AddressTypeId { get; set; }

    [ForeignKey("AddressId")]
    [InverseProperty("SupplierAddresses")]
    public virtual Address Address { get; set; } = null!;

    [ForeignKey("AddressTypeId")]
    [InverseProperty("SupplierAddresses")]
    public virtual AddressType AddressType { get; set; } = null!;

    [ForeignKey("SupplierId")]
    [InverseProperty("SupplierAddresses")]
    public virtual Supplier Supplier { get; set; } = null!;
}
