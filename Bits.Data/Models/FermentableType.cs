using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("fermentable_type")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class FermentableType
{
    [Key]
    [Column("fermentable_type_id")]
    public int FermentableTypeId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("FermentableType")]
    public virtual ICollection<Fermentable> Fermentables { get; set; } = new List<Fermentable>();
}
