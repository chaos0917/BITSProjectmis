using Bits.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bits.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly BitsContext _context;

        public RecipesController(BitsContext context)
        {
            _context = context;
        }

        // GET: api/recipes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetRecipe(int id)
        {
            var recipe = await _context.Recipes
                .Where(r => r.RecipeId == id)
                .Select(r => new
                {
                    r.RecipeId,
                    r.Name,

                    Ingredients = r.RecipeIngredients
                        .Select(ri => new
                        {
                            ri.IngredientId,
                            IngredientName = ri.Ingredient.Name,
                            
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();

            if (recipe == null)
            {
                return NotFound();
            }

            return Ok(recipe);
        }
    }
}
