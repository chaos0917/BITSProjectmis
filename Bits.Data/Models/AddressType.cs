using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("address_type")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class AddressType
{
    [Key]
    [Column("address_type_id")]
    public int AddressTypeId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("AddressType")]
    public virtual ICollection<SupplierAddress> SupplierAddresses { get; set; } = new List<SupplierAddress>();
}
