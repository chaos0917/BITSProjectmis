using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[PrimaryKey("BatchId", "BrewContainerId")]
[Table("batch_container")]
[Index("BrewContainerId", Name = "batch_container_brew_container_FK_idx")]
public partial class BatchContainer
{
    [Key]
    [Column("batch_id")]
    public int BatchId { get; set; }

    [Key]
    [Column("brew_container_id")]
    public int BrewContainerId { get; set; }

    [Column("date_in", TypeName = "datetime")]
    public DateTime DateIn { get; set; }

    [Column("date_out", TypeName = "datetime")]
    public DateTime? DateOut { get; set; }

    [Column("volume")]
    public double? Volume { get; set; }

    [ForeignKey("BatchId")]
    [InverseProperty("BatchContainers")]
    public virtual Batch Batch { get; set; } = null!;

    [ForeignKey("BrewContainerId")]
    [InverseProperty("BatchContainers")]
    public virtual BrewContainer BrewContainer { get; set; } = null!;
}
