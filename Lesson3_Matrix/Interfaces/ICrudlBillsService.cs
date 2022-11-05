using Coffee.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Interfaces
{
    public interface ICrudlBillsService : IGetAllService, IUpdateService
    {
        public List<Bill> GetAllBill();
        public Bill GetBill(Guid id);
        public void UpdateBill(Bill bill);
        public void CreateFirstBill(Guid billId, int userId);

    }
}
