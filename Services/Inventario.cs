
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services;

public class Inventario
{
    private readonly List<Producto> productos = new();

    public bool AgregarProducto(Producto producto)
    {
        foreach (Producto item in productos)
        {
            
if (item.Codigo.Equals(
    producto.Codigo,
    StringComparison.OrdinalIgnoreCase))
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


public Producto? BuscarPorCodigo(string codigo)
{
    foreach (Producto producto in productos)
    {
        if (producto.Codigo.Equals(
            codigo,
            StringComparison.OrdinalIgnoreCase))
        {
            return producto;
        }
    }

    return null;
}


}

