using Bits.Data.Models;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;

namespace Bits.Tests
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void CanGetAllRecipes()
        {
            using var context = TestHelper.GetContext();

            var recipes = context.Recipes
                .Select(r => new
                {
                    r.RecipeId,
                    r.Name
                })
                .ToList();

            NUnit.Framework.Assert.That(recipes, Is.Not.Null);
            NUnit.Framework.Assert.That(recipes.Count, Is.GreaterThan(0));
        }

        [Test]
        public void CanGetSingleRecipeWithIngredients()
        {
            using var context = TestHelper.GetContext();

            var firstId = context.Recipes
                .Select(r => r.RecipeId)
                .FirstOrDefault();

            NUnit.Framework.Assert.That(firstId, Is.GreaterThan(0));

            var recipe = context.Recipes
                .Include(r => r.RecipeIngredients)
                    .ThenInclude(ri => ri.Ingredient)
                .Single(r => r.RecipeId == firstId);

            NUnit.Framework.Assert.That(recipe, Is.Not.Null);
            NUnit.Framework.Assert.That(recipe.RecipeIngredients.Count, Is.GreaterThan(0));
        }
    }
}
