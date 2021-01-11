using CoffeeShop.Models;
using System.Collections.Generic;

namespace CoffeeShop.Repositories
{
    public interface ICoffeeRepository
    {
        void AddCoffee(Coffee coffee);
        void DeleteCoffe(int id);
        Coffee GetACoffee(int id);
        List<Coffee> GetAllCoffees();
        void UpdateCoffee(Coffee coffee);
    }
}