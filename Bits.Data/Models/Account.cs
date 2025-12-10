using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("account")]
public partial class Account
{
    [Key]
    [Column("account_id")]
    public int AccountId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Column("address")]
    [StringLength(100)]
    public string? Address { get; set; }

    [Column("city")]
    [StringLength(50)]
    public string? City { get; set; }

    [Column("state")]
    [StringLength(2)]
    public string? State { get; set; }

    [Column("zipcode")]
    [StringLength(10)]
    public string? Zipcode { get; set; }

    [Column("phone")]
    [StringLength(10)]
    public string? Phone { get; set; }

    [Column("contact_name")]
    [StringLength(100)]
    public string? ContactName { get; set; }

    [Column("sales_person_name")]
    [StringLength(100)]
    public string? SalesPersonName { get; set; }

    [InverseProperty("Account")]
    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
}
