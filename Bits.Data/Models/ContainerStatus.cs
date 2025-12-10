using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("container_status")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class ContainerStatus
{
    [Key]
    [Column("container_status_id")]
    public int ContainerStatusId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [InverseProperty("ContainerStatus")]
    public virtual ICollection<BrewContainer> BrewContainers { get; set; } = new List<BrewContainer>();
}
