using PizzaPlace.Services;

namespace PizzaPlace.Models
{
    public class Estados
    {
        public MenuService Menu { get; } = new MenuService();
        public Cestas Cesta { get; } = new Cestas();
        public Interfaz Interfaz { get; set; } = new Interfaz();
        public decimal PrecioTotal => Cesta.Pedidos.Sum(Id => Menu.GetPizza(Id)!.Precio);
    }
}
