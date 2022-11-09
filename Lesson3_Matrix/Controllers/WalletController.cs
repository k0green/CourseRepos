using Coffee.Entities;
using Coffee.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Controllers
{
    public class WalletController : Controller
    {
        private readonly ICrudlWalletService _crudlWalletService;


        public WalletController(ICrudlWalletService crudlWalletService)
        {
            _crudlWalletService = crudlWalletService;
        }
       
        public async Task<IActionResult> DisplayWallets()
        {
            return View(_crudlWalletService.GetAllWallet());
        }

        public IActionResult CreateWallet()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateWallet(Wallet wallet)
        {
            _crudlWalletService.UpdateWallet(Convert.ToInt32(Request.Cookies["userId"]));
            return RedirectToAction("UserFirstPage", "Home");
        }

        [HttpGet]
        [ActionName("DeleteWallet")]
        public async Task<IActionResult> ConfirmDeleteWallet(int? id)
        {
            if (id != null)
            {
                return View(_crudlWalletService.ConfirmDeleteWallet(id));
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteWallet(int? id)
        {
            if (id != null)
            {
                _crudlWalletService.DeleteWallet(id);
                return RedirectToAction("DisplayWallets");
            }
            return NotFound();
        }
    }
}
