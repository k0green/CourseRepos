using Coffee.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.Interfaces
{
    public interface ICrudlDrinkService : ICreateService, IDeleteService, IUpdateService, IGetAllService
    {
        public List<Drink> GetAllDrink();
        public Drink GetDrink(int id);
        public void CreateDrink(Drink drink);
        public Drink UpdateDrink(int? id);
        public void UpdateDrink(Drink drink);
        public void DeleteDrink(int? id);
        public Drink ConfirmDeleteDrink(int? id);

    }
}
