using Coffee.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Interfaces
{
    public interface ICrudlBillDrinkService : IGetAllService, ICreateService
    {
        public List<Billdrink> GetAllBillDrink();
        public Billdrink GetBillDrink(Guid id);
        public void CreateBillDrink(Guid billId, int drinkId, float coast);
        public IQueryable<Billdrink> GetAllBillDrinkWithCondition(Guid id);
        public void GetSum(Guid id);


    }
}
