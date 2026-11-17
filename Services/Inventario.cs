
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services;

public class Inventario
{
    private readonly List<Producto> productos = new();

    public bool AgregarProducto(Producto producto)
    {
        foreach (Producto item in productos)
        {
            if (item.Codigo == producto.Codigo)
            {
                return false;
            }
        }

        productos.Add(producto);
        return true;
    }

    public List<Producto> ObtenerProductos()
    {
        return new List<Producto>(productos);
    }
}
