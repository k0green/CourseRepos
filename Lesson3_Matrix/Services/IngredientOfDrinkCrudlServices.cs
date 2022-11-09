using Coffee.Entities;
using Coffee.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Coffee.Services
{
    public class IngredientOfDrinkCrudlServices : ICrudlIngredientOfDrinkService
    {

        private readonly IDbContext _dbContext;
        private readonly ICrudlIngredientService _crudlIngredientService;

        public IngredientOfDrinkCrudlServices(IDbContext dbContext, ICrudlIngredientService crudlIngredient)
        {
            _dbContext = dbContext;
            _crudlIngredientService = crudlIngredient;
        }

        public Drinksingredient ConfirmDeleteDrinkingredient(int? idd, int? idi)
        {
            Drinksingredient ingredientOfdrinks = _dbContext.Drinksingredients.FirstOrDefault(p => p.DrinkId == idd && p.IngredientsId == idi);
            return ingredientOfdrinks;
        }

        public void CreateDrinksingredient(DrinksingredientItemModel drinkIngredientItemModel)
        {
            var drinkIngredient = new Drinksingredient
            {
                DrinkId = drinkIngredientItemModel.DrinkId,
                IngredientsId = drinkIngredientItemModel.IngredientsId,
                AmountInOneDrink = drinkIngredientItemModel.AmountInOneDrink,
            };
            try
            {
                _dbContext.Drinksingredients.Add(drinkIngredient);
                _dbContext.SaveChanges();
            }
            catch
            {
                _dbContext.Drinksingredients.Remove(drinkIngredient);
                throw;
            }
        }

        public void DecreaseIngredientAmount(int id)
        {
            var drinksingredient = GetAllDrinksIngredientWithCondition(id);
            foreach (var drink in drinksingredient)
            {
                var ingredient = _crudlIngredientService.GetIngredient(drink.IngredientsId);
                ingredient.Amount -= drink.AmountInOneDrink;
            }
            _dbContext.SaveChanges();
        }

        public void DeleteDrinkingredient(int? idd, int? idi)
        {
            Drinksingredient drinksIngredient = _dbContext.Drinksingredients.FirstOrDefault(p => p.DrinkId == idd && p.IngredientsId == idi);
            if (drinksIngredient != null)
            {
                _dbContext.Drinksingredients.Remove(drinksIngredient);
                _dbContext.SaveChanges();
            }
        }

        public List<Drinksingredient> GetAllDrinksIngredientWithCondition(int id)
        {
            var drinksingredient = _dbContext.Drinksingredients.Where(b => b.DrinkId == id).ToList();
            return drinksingredient;
        }

        public List<DrinksingredientItemModel> GetAllDrinkingredient()
        {
            var allIndredientOfDrink = _dbContext.Drinksingredients.Select(c=>new DrinksingredientItemModel 
            { DrinkId = c.DrinkId,
              IngredientsId = c.IngredientsId, 
              AmountInOneDrink = c.AmountInOneDrink
            }).ToList();
            return allIndredientOfDrink;
        }

        public Drinksingredient UpdateDrinkingredient(int? idd, int? idi)
        {
            Drinksingredient indredientOfDrink = _dbContext.Drinksingredients.FirstOrDefault(p => p.DrinkId == idd && p.IngredientsId == idi);
            return indredientOfDrink;
        }

        public void UpdateDrinksingredient(DrinksingredientItemModel drinkIngredientItemModel)
        {
            var drinkIngredient = new Drinksingredient
            {
                DrinkId = drinkIngredientItemModel.DrinkId,
                IngredientsId = drinkIngredientItemModel.IngredientsId,
                AmountInOneDrink = drinkIngredientItemModel.AmountInOneDrink,
            };
            try
            {
                _dbContext.Drinksingredients.Update(drinkIngredient);
                _dbContext.SaveChanges();
            }
            catch
            {
                _dbContext.Drinksingredients.Remove(drinkIngredient);
                throw;
            }
        }
    }
}
