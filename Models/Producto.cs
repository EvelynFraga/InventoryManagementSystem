
namespace InventoryManagementSystem.Models;

public class Producto
{
    public int Id { get; set; }

    public string Codigo { get; set; } = string.Empty;

    public string Nombre { get; set; } = string.Empty;

    public string Categoria { get; set; } = string.Empty;

    public string Ubicacion { get; set; } = string.Empty;

    public int StockActual { get; set; }

    public int StockMinimo { get; set; }
}
