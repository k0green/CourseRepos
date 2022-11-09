using Coffee.Entities;
using Coffee.Interfaces;

namespace Coffee.Services
{
    public class IngredientCrudlServices : ICrudlIngredientService
    {

        private readonly IDbContext _dbContext;

        public IngredientCrudlServices(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Ingredient ConfirmDeleteIngredient(int? id)
        {
            Ingredient ingredient = _dbContext.Ingredients?.FirstOrDefault(p => p.Id == id);
                return ingredient;
        }

        public void CreateIngredient(Ingredient ingredient)
        {
            _dbContext.Ingredients.Add(ingredient);
            _dbContext.SaveChanges();
        }

        public void DeleteIngredient(int? id)
        {
            Ingredient ingredient = _dbContext.Ingredients.FirstOrDefault(p => p.Id == id);
            if (ingredient != null)
            {
                _dbContext.Ingredients.Remove(ingredient);
                _dbContext.SaveChanges();
            }
        }

        public List<Ingredient> GetAllIngredient()
        {
            var allIngredients = _dbContext.Ingredients;
            return allIngredients.ToList();
        }

        public Ingredient UpdateIngredient(int? id)
        {
            Ingredient ingredient = _dbContext.Ingredients?.FirstOrDefault(p => p.Id == id);
                return ingredient;
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            _dbContext.Ingredients.Update(ingredient);
            _dbContext.SaveChanges();
        }

        public Ingredient GetIngredient(int? id)
        {
            Ingredient ingredient = _dbContext.Ingredients.FirstOrDefault(p => p.Id == id);
            return ingredient;
        }
    }
}
