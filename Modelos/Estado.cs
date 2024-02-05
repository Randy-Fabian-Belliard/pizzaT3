namespace PizzaPlace.Shared
{
  public class Estado
  {
    public MenuServices Menu { get; } = new MenuServices();     
    public CompraCesta Cesta { get; } = new CompraCesta();
    public Interfaz Interfaz { get; set; } = new Interfaz();
    public decimal PrecioTotal => Cesta.Pedidos.Sum(id => Menu.GetPizza(id)!.Precio);
  }
}