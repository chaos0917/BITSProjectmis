using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("app_config")]
public partial class AppConfig
{
    [Key]
    [Column("brewery_id")]
    public int BreweryId { get; set; }

    [Column("default_units")]
    [StringLength(50)]
    public string DefaultUnits { get; set; } = null!;

    [Column("brewery_name")]
    [StringLength(200)]
    public string BreweryName { get; set; } = null!;

    [Column("home_page_text")]
    [StringLength(5000)]
    public string? HomePageText { get; set; }

    [Column("brewery_logo")]
    [StringLength(50)]
    public string? BreweryLogo { get; set; }

    [Column("home_page_background_image")]
    [StringLength(50)]
    public string? HomePageBackgroundImage { get; set; }

    [Column("color_1")]
    [StringLength(10)]
    public string? Color1 { get; set; }

    [Column("color_2")]
    [StringLength(10)]
    public string? Color2 { get; set; }

    [Column("color_3")]
    [StringLength(10)]
    public string? Color3 { get; set; }

    [Column("color_white")]
    [StringLength(10)]
    public string? ColorWhite { get; set; }

    [Column("color_black")]
    [StringLength(10)]
    public string? ColorBlack { get; set; }
}
