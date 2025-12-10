using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("adjunct_type")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class AdjunctType
{
    [Key]
    [Column("adjunct_type_id")]
    public int AdjunctTypeId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("AdjunctType")]
    public virtual ICollection<Adjunct> Adjuncts { get; set; } = new List<Adjunct>();
}
