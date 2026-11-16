
using InventoryManagementSystem.Models;

Console.WriteLine("=== SISTEMA DE INVENTARIO ===");
Console.WriteLine();

Producto producto = new Producto
{
    Codigo = "REP-001",
    Nombre = "Rodamiento 6204",
    Categoria = "Repuestos",
    Ubicacion = "A-01-02",
    StockActual = 35,
    StockMinimo = 10
};

Console.WriteLine("DETALLE DEL PRODUCTO");
Console.WriteLine($"Código: {producto.Codigo}");
Console.WriteLine($"Nombre: {producto.Nombre}");
Console.WriteLine($"Categoría: {producto.Categoria}");
Console.WriteLine($"Ubicación: {producto.Ubicacion}");
Console.WriteLine($"Stock actual: {producto.StockActual}");
Console.WriteLine($"Stock mínimo: {producto.StockMinimo}");
