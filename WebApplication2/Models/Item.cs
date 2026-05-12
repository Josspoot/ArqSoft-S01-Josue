namespace WebApplication2.Models;

public class Item
{
    public int Id { get; set; }
    public string Cliente { get; set; }
    public string Platillo { get; set; }
    public int Cantidad { get; set; }
    public string TipoConsumo { get; set; }
    public string InstruccionesEspeciales { get; set; }
}