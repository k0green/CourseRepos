using Coffee.Entities;
using Coffee.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Controllers
{
    public class DrinkController : Controller
    {

        private readonly ICrudlDrinkService _crudlDrinkService;

        public DrinkController(ICrudlDrinkService crudlDrinkService)
        {
            _crudlDrinkService = crudlDrinkService;
        }

        public async Task<IActionResult> DisplayDrinks()
        {
            return View(_crudlDrinkService.GetAllDrink());
        }

        public IActionResult CreateDrink()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDrink(Drink drink)
        {
            _crudlDrinkService.CreateDrink(drink);
            return RedirectToAction("DisplayDrinks");
        }

        public async Task<IActionResult> EditDrinks(int? id)
        {
            if (id != null)
            {
                return View(_crudlDrinkService.UpdateDrink(id));
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> EditDrink(Drink drinks)
        {
            _crudlDrinkService.UpdateDrink(drinks);
            return RedirectToAction("DisplayDrinks");
        }

        [HttpGet]
        [ActionName("DeleteDrink")]
        public async Task<IActionResult> ConfirmDeleteDrink(int? id)
        {
            if (id != null)
            {
                return View(_crudlDrinkService.ConfirmDeleteDrink(id));
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteDrink(int? id)
        {
            if (id != null)
            {
                _crudlDrinkService.DeleteDrink(id);
                return RedirectToAction("DisplayDrinks");
            }
            return NotFound();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
