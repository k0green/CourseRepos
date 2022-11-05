using Coffee.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Interfaces
{
    public interface ICrudlWalletService : ICreateService, IDeleteService, IGetAllService
    {
        public List<Wallet> GetAllWallet();
        public Wallet GetOneWallet(int? id);
        public Wallet GetWalletByUserId(int? id);
        public void UpdateWallet(int id);
        public void CreateWallet(int id);
        public void DeleteWallet(int? id);
        public Wallet ConfirmDeleteWallet(int? id);
        public void WithdrawMoney(Wallet wallet, Drink drink);

    }
}
