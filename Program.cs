
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;

Console.WriteLine("=== SISTEMA DE INVENTARIO ===");
Console.WriteLine();

Inventario inventario = new Inventario();

Producto producto1 = new Producto
{
    Codigo = "REP-001",
    Nombre = "Rodamiento 6204",
    Categoria = "Repuestos",
    Ubicacion = "A-01-02",
    StockActual = 35,
    StockMinimo = 10
};

Producto producto2 = new Producto
{
    Codigo = "HER-014",
    Nombre = "Llave combinada 17 mm",
    Categoria = "Herramientas",
    Ubicacion = "B-02-01",
    StockActual = 12,
    StockMinimo = 5
};

Producto producto3 = new Producto
{
    Codigo = "MAT-008",
    Nombre = "Cable unipolar",
    Categoria = "Materiales",
    Ubicacion = "C-01-03",
    StockActual = 80,
    StockMinimo = 20
};

inventario.AgregarProducto(producto1);
inventario.AgregarProducto(producto2);
inventario.AgregarProducto(producto3);

bool agregado = inventario.AgregarProducto(producto1);

if (!agregado)
{
    Console.WriteLine("No se pudo registrar el producto: el código ya existe.");
}

Console.WriteLine();
Console.WriteLine("PRODUCTOS REGISTRADOS");
Console.WriteLine("---------------------");

foreach (Producto producto in inventario.ObtenerProductos())
{
    Console.WriteLine($"Código: {producto.Codigo}");
    Console.WriteLine($"Nombre: {producto.Nombre}");
    Console.WriteLine($"Categoría: {producto.Categoria}");
    Console.WriteLine($"Ubicación: {producto.Ubicacion}");
    Console.WriteLine($"Stock: {producto.StockActual}");
    Console.WriteLine("---------------------");
}
