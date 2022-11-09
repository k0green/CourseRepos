using Coffee.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Interfaces
{
    public interface ICrudlIngredientService : ICreateService, IDeleteService, IUpdateService, IGetAllService
    {
        public List<Ingredient> GetAllIngredient();
        public void CreateIngredient(Ingredient ingredient);
        public Ingredient UpdateIngredient(int? id);
        public void UpdateIngredient(Ingredient ingredient);
        public void DeleteIngredient(int? id);
        public Ingredient ConfirmDeleteIngredient(int? id);
        public Ingredient GetIngredient(int? id);

    }
}
