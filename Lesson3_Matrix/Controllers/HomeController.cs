using Coffee.Entities;
using Coffee.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Coffee.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICrudlDrinkService _crudlDrinkService;
        private readonly ICrudlIngredientService _crudlIngredientService;
        private readonly ICrudlIngredientOfDrinkService _crudlIngredientOfDrinkService;
        private readonly ICrudlWalletService _crudlWalletService;
        private readonly ICrudlBillsService _crudlBillsService;
        private readonly ICrudlBillDrinkService _crudlBillDrinkService;
        private readonly ICrudlUserService _crudlUserService;
        private readonly ICrudlRoleService _crudlRoleService;




        public HomeController(ILogger<HomeController> logger,
            ICrudlDrinkService crudlDrinkService,
            ICrudlIngredientService crudlIngredientService,
            ICrudlIngredientOfDrinkService crudlIngredientOfDrinkService,
            ICrudlWalletService crudlWalletService,
            ICrudlBillsService crudlBillsService,
            ICrudlBillDrinkService crudlBillDrinkService,
            ICrudlUserService crudlUserService,
            ICrudlRoleService crudlRoleService)

        {
            _crudlDrinkService = crudlDrinkService;
            _crudlIngredientService = crudlIngredientService;
            _crudlIngredientOfDrinkService = crudlIngredientOfDrinkService;
            _crudlWalletService = crudlWalletService;
            _crudlBillsService = crudlBillsService;
            _crudlBillDrinkService = crudlBillDrinkService;
            _crudlUserService = crudlUserService;
            _crudlRoleService = crudlRoleService;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return Content(User.Identity.Name);
        }

        [HttpGet]
        public async Task<IActionResult> UserFirstPage()
        {
            var wallets = _crudlWalletService.GetOneWallet(int.Parse(Request.Cookies["userId"]));
            if (wallets == null)
            {
                _crudlWalletService.CreateWallet(int.Parse(Request.Cookies["userId"]));
            }
            ViewData["UserId"] = Request.Cookies["userId"];
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AdminFirstPage()
        {
            //ViewData["AdminId"] = id;
            return View();
        }

        [HttpGet]
        [ActionName("UserProfile")]
        public async Task<IActionResult> UserProfile()
        {
            var userId = Request.Cookies["userId"];
            if (userId != null)
            {
                var users = _crudlUserService.GetUser(Convert.ToInt32(userId));
                var wallets = _crudlWalletService.GetWalletByUserId(users.Id);
                var roles = _crudlRoleService.GetRole(users.RoleId);
                ViewData["UserId"] = users.Id;
                ViewData["UserName"] = users.Name;
                ViewData["UserRole"] = roles.Name;
                if (wallets != null)
                {
                    ViewData["UserMoney"] = wallets.Money;
                }
                else
                    ViewData["UserMoney"] = "U haven't got money";
                return View();
            }
            return NotFound();
        }

        public async Task<IActionResult> MenuFirstPage()
        {
            var g = Guid.NewGuid();
            Response.Cookies.Append("BillFromMenuId", $"{g}");
            _crudlBillsService.CreateFirstBill(g, Convert.ToInt32(Request.Cookies["userId"]));
            return View();
        }

        public async Task<IActionResult> Menu()
        {
            return View(_crudlDrinkService.GetAllDrink());
        }

        public async Task<IActionResult> MenuPost(int id)
        {
            var wallet = _crudlWalletService.GetWalletByUserId(Convert.ToInt32(Request.Cookies["userId"]));

            var drink = _crudlDrinkService.GetDrink(id);

            _crudlIngredientOfDrinkService.DecreaseIngredientAmount(id);

            _crudlWalletService.WithdrawMoney(wallet, drink);

            _crudlBillDrinkService.CreateBillDrink(Guid.Parse(Request.Cookies["BillFromMenuId"]), id, drink.Coast);

            return RedirectToAction("Menu");
        }

        [HttpGet]
        public async Task<IActionResult> BuyDrink()
        {
            return View(_crudlBillDrinkService.GetAllBillDrink());
        }

        public async Task<IActionResult> BuyDrinkPost(Bill bill)
        {
            _crudlBillDrinkService.GetSum(Guid.Parse(Request.Cookies["BillFromMenuId"]));
            return RedirectToAction("WaitingPage");
        }

        //public async Task<IActionResult> DisplayDrinks()
        //{
        //    return View(_crudlDrinkService.GetAllDrink());
        //}

        //public IActionResult CreateDrink()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateDrink(Drink drink)
        //{
        //    _crudlDrinkService.CreateDrink(drink);
        //    return RedirectToAction("DisplayDrinks");
        //}

        //public async Task<IActionResult> EditDrinks(int? id)
        //{
        //    if (id != null)
        //    {
        //            return View(_crudlDrinkService.UpdateDrink(id));
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public async Task<IActionResult> EditDrink(Drink drinks)
        //{
        //    _crudlDrinkService.UpdateDrink(drinks);
        //    return RedirectToAction("DisplayDrinks");
        //}

        //[HttpGet]
        //[ActionName("DeleteDrink")]
        //public async Task<IActionResult> ConfirmDeleteDrink(int? id)
        //{
        //    if (id != null)
        //    {
        //        return View(_crudlDrinkService.ConfirmDeleteDrink(id));
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DeleteDrink(int? id)
        //{
        //    if (id != null)
        //    {
        //        _crudlDrinkService.DeleteDrink(id);
        //        return RedirectToAction("Index");
        //    }
        //    return NotFound();
        //}

        //public async Task<IActionResult> DisplayIngredients()
        //{
        //    return View(_crudlIngredientService.GetAllIngredient());
        //}

        //public IActionResult CreateIngredient()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateIngredient(Ingredient ingredient)
        //{
        //    _crudlIngredientService.CreateIngredient(ingredient);
        //    return RedirectToAction("DisplayIngredients");
        //}
        //public async Task<IActionResult> EditIngredient(int? id)
        //{
        //    if (id != null)
        //    {
        //            return View(_crudlIngredientService.UpdateIngredient(id));
        //    }
        //    return NotFound();
        //}
        //[HttpPost]
        //public async Task<IActionResult> EditIngredient(Ingredient ingredient)
        //{
        //    _crudlIngredientService.UpdateIngredient(ingredient);
        //    return RedirectToAction("DisplayIngredients");
        //}

        //[HttpGet]
        //[ActionName("DeleteIngredient")]
        //public async Task<IActionResult> ConfirmDeleteIngredient(int? id)
        //{
        //    if (id != null)
        //    {
        //            return View(_crudlIngredientService.ConfirmDeleteIngredient(id));
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DeleteIngredient(int? id)
        //{
        //    if (id != null)
        //    {
        //        _crudlIngredientService.DeleteIngredient(id);
        //        return RedirectToAction("DisplayIngredients");
        //    }
        //    return NotFound();
        //}

        //public async Task<IActionResult> DisplayIngredientOfDrink()
        //{
        //    return View(_crudlIngredientOfDrinkService.GetAllDrinkingredient());
        //}

        //public IActionResult CreateIngredientOfDrink()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateIngredientOfDrink(Drinksingredient drinkIngredient)
        //{
        //    _crudlIngredientOfDrinkService.CreateDrinksingredient(drinkIngredient);
        //    return RedirectToAction("DisplayIngredientOfDrink");
        //}
        //public async Task<IActionResult> EditIngredientOfDrink(int? idd, int? idi)
        //{
        //    if (idd != null && idi != null)
        //    {
        //            return View(_crudlIngredientOfDrinkService.UpdateDrinkingredient(idd, idi));
        //    }
        //    return NotFound();
        //}
        //[HttpPost]
        //public async Task<IActionResult> EditIngredientOfDrink(Drinksingredient drinksIngredient)
        //{
        //    _crudlIngredientOfDrinkService.UpdateDrinksingredient(drinksIngredient);
        //    return RedirectToAction("DisplayIngredientOfDrink");
        //}

        //[HttpGet]
        //[ActionName("DeleteIngredientOfDrink")]
        //public async Task<IActionResult> ConfirmDeleteIngredientOfDrink(int? idd, int? idi)
        //{
        //    if (idd != null && idi != null)
        //    {
        //            return View(_crudlIngredientOfDrinkService.ConfirmDeleteDrinkingredient(idd, idi));
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DeleteIngredientOfDrink(int? idd, int? idi)
        //{
        //    if (idd != null && idi != null)
        //    {
        //            _crudlIngredientOfDrinkService.DeleteDrinkingredient(idd, idi);
        //            return RedirectToAction("DisplayIngredientOfDrink");
        //    }
        //    return NotFound();
        //}

        //public async Task<IActionResult> DisplayWallets()
        //{
        //    return View(_crudlWalletService.GetAllWallet());
        //}

        //public IActionResult CreateWallet() 
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateWallet(Wallet wallet)
        //{
        //    _crudlWalletService.UpdateWallet(Convert.ToInt32(Request.Cookies["userId"]));
        //    return RedirectToAction("UserFirstPage");
        //}

        //[HttpGet]
        //[ActionName("DeleteWallet")]
        //public async Task<IActionResult> ConfirmDeleteWallet(int? id)
        //{
        //    if (id != null)
        //    {
        //            return View(_crudlWalletService.ConfirmDeleteWallet(id));
        //    }
        //    return NotFound();
        //}

        //[HttpPost]
        //public async Task<IActionResult> DeleteWallet(int? id)
        //{
        //    if (id != null)
        //    {
        //        _crudlWalletService.DeleteWallet(id);
        //        return RedirectToAction("DisplayWallets");
        //    }
        //    return NotFound();
        //}

        public async Task<IActionResult> DisplayBills()
        {
            return View(_crudlBillsService.GetAllBill());
        }
        public async Task<IActionResult> WaitingPage()
        {
            return View();
        }

    }
}