
using InventoryManagementSystem.Models;
using InventoryManagementSystem.Services;

namespace InventoryManagementSystem.UI;

public class MenuConsola
{
    private readonly Inventario inventario = new();

    public void Iniciar()
    {
        string? opcion;

        do
        {
            Console.WriteLine();
            Console.WriteLine("=== SISTEMA DE INVENTARIO ===");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Consultar inventario");
            Console.WriteLine("0. Salir");
            Console.WriteLine();
            Console.Write("Seleccione una opción: ");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarProducto();
                    break;

                case "2":
                    MostrarProductos();
                    break;

                case "0":
                    Console.WriteLine("Finalizando el sistema...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != "0");
    }

    private void RegistrarProducto()
    {
        Console.WriteLine();
        Console.WriteLine("--- REGISTRAR PRODUCTO ---");

        Console.Write("Código: ");
        string codigo = Console.ReadLine()?.Trim() ?? "";

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine()?.Trim() ?? "";

        Console.Write("Categoría: ");
        string categoria = Console.ReadLine()?.Trim() ?? "";

        Console.Write("Ubicación: ");
        string ubicacion = Console.ReadLine()?.Trim() ?? "";

        Console.Write("Stock actual: ");
        bool stockValido = int.TryParse(Console.ReadLine(), out int stockActual);

        Console.Write("Stock mínimo: ");
        bool minimoValido = int.TryParse(Console.ReadLine(), out int stockMinimo);

        if (string.IsNullOrWhiteSpace(codigo) ||
            string.IsNullOrWhiteSpace(nombre) ||
            string.IsNullOrWhiteSpace(categoria) ||
            string.IsNullOrWhiteSpace(ubicacion) ||
            !stockValido ||
            !minimoValido ||
            stockActual < 0 ||
            stockMinimo < 0)
        {
            Console.WriteLine("Error: verificá los datos ingresados.");
            return;
        }

        Producto producto = new()
        {
            Codigo = codigo,
            Nombre = nombre,
            Categoria = categoria,
            Ubicacion = ubicacion,
            StockActual = stockActual,
            StockMinimo = stockMinimo
        };

        bool agregado = inventario.AgregarProducto(producto);

        Console.WriteLine(agregado
            ? "Producto registrado correctamente."
            : "Error: ya existe un producto con ese código.");
    }

    private void MostrarProductos()
    {
        List<Producto> productos = inventario.ObtenerProductos();

        Console.WriteLine();
        Console.WriteLine("--- INVENTARIO ---");

        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos registrados.");
            return;
        }

        foreach (Producto producto in productos)
        {
            Console.WriteLine();
            Console.WriteLine($"Código: {producto.Codigo}");
            Console.WriteLine($"Nombre: {producto.Nombre}");
            Console.WriteLine($"Categoría: {producto.Categoria}");
            Console.WriteLine($"Ubicación: {producto.Ubicacion}");
            Console.WriteLine($"Stock actual: {producto.StockActual}");
            Console.WriteLine($"Stock mínimo: {producto.StockMinimo}");
            Console.WriteLine("----------------------");
        }
    }
}
