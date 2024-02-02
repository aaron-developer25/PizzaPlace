using PizzaPlace.Services;

namespace PizzaPlace.Models
{
    public class Estado
    {
        public MenuService Menu { get; } = new MenuService();
        public Cesta Cesta { get; } = new Cesta();
        public Interfaz Interfaz { get; set; } = new Interfaz();
        public decimal PrecioTotal => Cesta.Pedidos.Sum(Id => Menu.GetPizza(Id)!.Precio);
    }
}
