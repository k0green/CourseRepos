using Coffee.Entities;
using Coffee.Interfaces;

namespace Coffee.Services
{
    public class BillsCrudlServices : ICrudlBillsService
    {

        private readonly IDbContext _dbContext;

        public BillsCrudlServices(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Bill> GetAllBill()
        {
            var allBill = _dbContext.Bills.ToList();
            return allBill;
        }

        public Bill GetBill(Guid id)
        {
            Bill bill = _dbContext.Bills.FirstOrDefault(p => p.Id == id);
            return bill;
        }

        public void UpdateBill(Bill bill)
        {
            _dbContext.Bills.Update(bill);
            _dbContext.SaveChanges();
        }

        public void CreateFirstBill(Guid billId, int userId)
        {
            Bill bill = new Bill();
            bill.Id = billId;
            bill.Sum = 0;
            bill.UserId = userId;
            _dbContext.Bills.Add(bill);
            _dbContext.SaveChanges();
        }
    }
}
