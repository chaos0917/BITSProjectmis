using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("container_size")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class ContainerSize
{
    [Key]
    [Column("container_size_id")]
    public int ContainerSizeId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("max_volume")]
    public double? MaxVolume { get; set; }

    [Column("working_volume")]
    public double? WorkingVolume { get; set; }

    [InverseProperty("ContainerSize")]
    public virtual ICollection<BrewContainer> BrewContainers { get; set; } = new List<BrewContainer>();
}
