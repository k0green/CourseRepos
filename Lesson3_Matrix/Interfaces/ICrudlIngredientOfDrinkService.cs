using Coffee.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Interfaces
{
    public interface ICrudlIngredientOfDrinkService : ICreateService, IDeleteService, IUpdateService, IGetAllService
    {
        public List<DrinksingredientItemModel> GetAllDrinkingredient();
        public void CreateDrinksingredient(DrinksingredientItemModel drinkIngredientItemModel);
        public Drinksingredient UpdateDrinkingredient(int? idd, int? idi);
        public void UpdateDrinksingredient(DrinksingredientItemModel drinkIngredientItemModel);
        public void DeleteDrinkingredient(int? idd, int? idi);
        public Drinksingredient ConfirmDeleteDrinkingredient(int? idd, int? idi);
        public void DecreaseIngredientAmount(int id);
        public List<Drinksingredient> GetAllDrinksIngredientWithCondition(int id);



    }
}
