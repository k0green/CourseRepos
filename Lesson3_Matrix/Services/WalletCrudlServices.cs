using Coffee.Entities;
using Coffee.Interfaces;

namespace Coffee.Services
{
    public class WalletCrudlServices : ICrudlWalletService
    {

        private readonly IDbContext _dbContext;
        private readonly ICrudlDrinkService _crudldrinkService;

        public WalletCrudlServices(IDbContext dbContext, ICrudlDrinkService crudlDrinkService)
        {
            _dbContext = dbContext;
            _crudldrinkService = crudlDrinkService;
        }

        public Wallet ConfirmDeleteWallet(int? id)
        {
            Wallet wallets = _dbContext.Wallets.FirstOrDefault(p => p.Id == id);
            return wallets;
        }

        public void UpdateWallet(int id)
        {
            var wallets = _dbContext.Wallets.FirstOrDefault(p => p.UserId == id);
            var rnd = new Random();
            wallets.Money = rnd.Next(10, 25);
            _dbContext.Wallets.Update(wallets);
            _dbContext.SaveChanges();
        }

        public void CreateWallet(int id)
        {
            Wallet wallet = new Wallet();
            wallet.UserId = id;
            var rnd = new Random();
            wallet.Money = rnd.Next(10, 25);
            _dbContext.Wallets.Add(wallet);
            _dbContext.SaveChanges();
        }

        public void DeleteWallet(int? id)
        {
            Wallet wallets = _dbContext.Wallets.FirstOrDefault(p => p.Id == id);
            if (wallets != null)
            {
                _dbContext.Wallets.Remove(wallets);
                _dbContext.SaveChanges();
            }
        }

        public List<Wallet> GetAllWallet()
        {
            var allWallet = _dbContext.Wallets.ToList();
            return allWallet;
        }

        public Wallet GetOneWallet(int? id)
        {
            Wallet wallets = _dbContext.Wallets.FirstOrDefault(p => p.Id == id);
            return wallets;
        }

        public Wallet GetWalletByUserId(int? id)
        {
            Wallet wallets = _dbContext.Wallets.FirstOrDefault(d => d.UserId == id);
            return wallets;
        }

        public void WithdrawMoney(Wallet wallet, Drink drink)
        {
            wallet.Money -= drink.Coast;
            _dbContext.SaveChanges();
        }
    }
}
