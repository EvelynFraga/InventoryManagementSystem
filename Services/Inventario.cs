
using InventoryManagementSystem.Data;
using InventoryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Services;

public class Inventario
{
    public bool AgregarProducto(Producto producto)
    {
        using InventarioDbContext db = new();

        bool existe = db.Productos.Any(p =>
            p.Codigo == producto.Codigo);

        if (existe)
        {
            return false;
        }

        db.Productos.Add(producto);
        db.SaveChanges();

        return true;
    }

    public List<Producto> ObtenerProductos()
    {
        using InventarioDbContext db = new();

        return db.Productos
            .AsNoTracking()
            .OrderBy(p => p.Nombre)
            .ToList();
    }

    public Producto? BuscarPorCodigo(string codigo)
    {
        using InventarioDbContext db = new();

        return db.Productos
            .AsNoTracking()
            .FirstOrDefault(p => p.Codigo == codigo);
    }
}
