using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("supplier")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class Supplier
{
    [Key]
    [Column("supplier_id")]
    public int SupplierId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("phone")]
    [StringLength(50)]
    public string? Phone { get; set; }

    [Column("email")]
    [StringLength(50)]
    public string? Email { get; set; }

    [Column("website")]
    [StringLength(100)]
    public string? Website { get; set; }

    [Column("contact_first_name")]
    [StringLength(50)]
    public string? ContactFirstName { get; set; }

    [Column("contact_last_name")]
    [StringLength(50)]
    public string? ContactLastName { get; set; }

    [Column("contact_phone")]
    [StringLength(50)]
    public string? ContactPhone { get; set; }

    [Column("contact_email")]
    [StringLength(50)]
    public string? ContactEmail { get; set; }

    [Column("note")]
    [StringLength(1000)]
    public string? Note { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<IngredientInventoryAddition> IngredientInventoryAdditions { get; set; } = new List<IngredientInventoryAddition>();

    [InverseProperty("Supplier")]
    public virtual ICollection<SupplierAddress> SupplierAddresses { get; set; } = new List<SupplierAddress>();
}
