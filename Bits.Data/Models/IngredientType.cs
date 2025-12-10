using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bits.Data.Models;

[Table("ingredient_type")]
[Index("Name", Name = "name_UNIQUE", IsUnique = true)]
public partial class IngredientType
{
    [Key]
    [Column("ingredient_type_id")]
    public int IngredientTypeId { get; set; }

    [Column("name")]
    [StringLength(50)]
    public string Name { get; set; } = null!;

    [InverseProperty("IngredientType")]
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}
