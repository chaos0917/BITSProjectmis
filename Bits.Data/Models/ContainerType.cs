using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("container_type")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class ContainerType
{
    [Key]
    [Column("container_type_id")]
    public int ContainerTypeId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [InverseProperty("ContainerType")]
    public virtual ICollection<BrewContainer> BrewContainers { get; set; } = new List<BrewContainer>();
}
