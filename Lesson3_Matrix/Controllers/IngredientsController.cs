using Coffee.Entities;
using Coffee.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Controllers
{
    public class IngredientsController : Controller
    {
        private readonly ICrudlIngredientService _crudlIngredientService;

        public IngredientsController(ICrudlIngredientService crudlIngredientService)
        {
            _crudlIngredientService = crudlIngredientService;
        }
        public async Task<IActionResult> DisplayIngredients()
        {
            return View(_crudlIngredientService.GetAllIngredient());
        }

        public IActionResult CreateIngredient()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateIngredient(Ingredient ingredient)
        {
            _crudlIngredientService.CreateIngredient(ingredient);
            return RedirectToAction("DisplayIngredients");
        }
        public async Task<IActionResult> EditIngredient(int? id)
        {
            if (id != null)
            {
                return View(_crudlIngredientService.UpdateIngredient(id));
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditIngredient(Ingredient ingredient)
        {
            _crudlIngredientService.UpdateIngredient(ingredient);
            return RedirectToAction("DisplayIngredients");
        }

        [HttpGet]
        [ActionName("DeleteIngredient")]
        public async Task<IActionResult> ConfirmDeleteIngredient(int? id)
        {
            if (id != null)
            {
                return View(_crudlIngredientService.ConfirmDeleteIngredient(id));
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteIngredient(int? id)
        {
            if (id != null)
            {
                _crudlIngredientService.DeleteIngredient(id);
                return RedirectToAction("DisplayIngredients");
            }
            return NotFound();
        }
    }
}
