using PizzaPlace.Models;

namespace PizzaPlace.Services
{
    public class MenuService
    {
        public List<Pizzas> Pizzas { get; set; } = new List<Pizzas>();
        public void Add(Pizzas pizza) => Pizzas.Add(pizza);
        public Pizzas? GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
    }

}
