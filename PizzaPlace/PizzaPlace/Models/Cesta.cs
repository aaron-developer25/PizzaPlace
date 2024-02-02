namespace PizzaPlace.Models
{
    public class Cesta
    {
        public Clientes Cliente { get; set; } = new Clientes();
        public List<int> Pedidos { get; set; } = new List<int>();
        public bool Pago { get; set; }
        public void Add(int pizzaId) => Pedidos.Add(pizzaId);
        public void RemoveAt(int pos) => Pedidos.RemoveAt(pos);
    }
}
