using Coffee.Entities;
using Coffee.Interfaces;

namespace Coffee.Services
{
    public class DrinkCrudlServices : ICrudlDrinkService
    {

        private readonly IDbContext _dbContext;

        public DrinkCrudlServices(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Drink ConfirmDeleteDrink(int? id)
        {
            Drink drinks = _dbContext.Drinks?.FirstOrDefault(p => p.Id == id);
                return drinks;
        }

        public void CreateDrink(Drink drink)
        {
            _dbContext.Drinks.Add(drink);
            _dbContext.SaveChanges();
        }

        public void DeleteDrink(int? id)
        {
            Drink drinks = _dbContext.Drinks.FirstOrDefault(p => p.Id == id);
            if (drinks != null)
            {
                _dbContext.Drinks.Remove(drinks);
                _dbContext.SaveChanges();
            }
        }

        public List<Drink> GetAllDrink()
        {
            var allDrink = _dbContext.Drinks.ToList();
            return allDrink;
        }

        public Drink GetDrink(int id)
        {
            return _dbContext.Drinks.FirstOrDefault(d => d.Id == id);
        }

        public Drink UpdateDrink(int? id)
        {
            Drink drinks = _dbContext.Drinks?.FirstOrDefault(p => p.Id == id);
                return drinks;
        }

        public void UpdateDrink(Drink drink)
        {
            _dbContext.Drinks.Update(drink);
            _dbContext.SaveChanges();
        }
    }
}
