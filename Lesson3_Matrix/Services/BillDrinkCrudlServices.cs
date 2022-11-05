using Coffee.Entities;
using Coffee.Interfaces;
using Microsoft.Extensions.Hosting;

namespace Coffee.Services
{
    public class BillDrinkCrudlServices : ICrudlBillDrinkService
    {

        private readonly IDbContext _dbContext;
        private readonly ICrudlBillsService _crudlBillsService;


        public BillDrinkCrudlServices(IDbContext dbContext, ICrudlBillsService crudlBillsService)
        {
            _dbContext = dbContext;
            _crudlBillsService = crudlBillsService;
        }

        public List<Billdrink> GetAllBillDrink()
        {
            var allBillDrink = _dbContext.Billdrinks.ToList();
            return allBillDrink;
        }
        public Billdrink GetBillDrink(Guid id)
        {
            Billdrink billDrink = _dbContext.Billdrinks.FirstOrDefault(p => p.BillId == id);
            return billDrink;
        }

        public IQueryable<Billdrink> GetAllBillDrinkWithCondition(Guid id)
        {
            var allBillDrinkWithCondition = _dbContext.Billdrinks.Where(b => b.BillId == id);

            return allBillDrinkWithCondition;
        }

        public void GetSum(Guid id)
        {
            float? sum = 0;
            var billdrink = GetAllBillDrinkWithCondition(id);
            foreach (var coasts in billdrink)
            {
                sum += coasts.Coast;
            }
            var bills = _crudlBillsService.GetBill(id);
            bills.Sum = sum;
            _crudlBillsService.UpdateBill(bills);

        }

        public void CreateBillDrink(Guid billId, int drinkId, float coast)
        {
            Billdrink billdrink = new Billdrink();
            billdrink.BillId = billId;
            billdrink.DrinkId = drinkId;
            billdrink.Coast = coast;
            _dbContext.Billdrinks.Add(billdrink);
            _dbContext.SaveChanges();
        }
    }
}
