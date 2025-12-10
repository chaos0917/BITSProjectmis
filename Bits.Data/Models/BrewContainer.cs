using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("brew_container")]
[Index("ContainerSizeId", Name = "brew_container_container_size_idx")]
[Index("ContainerStatusId", Name = "brew_container_container_status_FK_idx")]
[Index("ContainerTypeId", Name = "brew_container_container_type_FK_idx")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class BrewContainer
{
    [Key]
    [Column("brew_container_id")]
    public int BrewContainerId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [Column("container_status_id")]
    public int ContainerStatusId { get; set; }

    [Column("container_type_id")]
    public int ContainerTypeId { get; set; }

    [Column("container_size_id")]
    public int ContainerSizeId { get; set; }

    [InverseProperty("BrewContainer")]
    public virtual Barrel? Barrel { get; set; }

    [InverseProperty("BrewContainer")]
    public virtual ICollection<BatchContainer> BatchContainers { get; set; } = new List<BatchContainer>();

    [ForeignKey("ContainerSizeId")]
    [InverseProperty("BrewContainers")]
    public virtual ContainerSize ContainerSize { get; set; } = null!;

    [ForeignKey("ContainerStatusId")]
    [InverseProperty("BrewContainers")]
    public virtual ContainerStatus ContainerStatus { get; set; } = null!;

    [ForeignKey("ContainerTypeId")]
    [InverseProperty("BrewContainers")]
    public virtual ContainerType ContainerType { get; set; } = null!;
}
