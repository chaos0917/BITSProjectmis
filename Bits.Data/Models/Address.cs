using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("address")]
public partial class Address
{
    [Key]
    [Column("address_id")]
    public int AddressId { get; set; }

    [Column("street_line_1")]
    [StringLength(100)]
    public string StreetLine1 { get; set; } = null!;

    [Column("street_line_2")]
    [StringLength(100)]
    public string? StreetLine2 { get; set; }

    [Column("city")]
    [StringLength(50)]
    public string City { get; set; } = null!;

    [Column("state")]
    [StringLength(50)]
    public string State { get; set; } = null!;

    [Column("zipcode")]
    [StringLength(50)]
    public string? Zipcode { get; set; }

    [Column("country")]
    [StringLength(50)]
    public string Country { get; set; } = null!;

    [InverseProperty("Address")]
    public virtual ICollection<SupplierAddress> SupplierAddresses { get; set; } = new List<SupplierAddress>();
}
