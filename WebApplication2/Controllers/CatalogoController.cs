using WebApplication2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalogo.Controllers;

public class CatalogoController : Controller
{
    private static List<Item> _items = new()
    {
        new Item
        {
            Id = 1,
            Cliente = "Josue Poot",
            Platillo = "Ramen Tonkotsu",
            Cantidad = 1,
            TipoConsumo = "Para comer aquí",
            InstruccionesEspeciales = "Extra chashu, sin cebollín."
        },
        new Item
        {
            Id = 2,
            Cliente = "Dr. Jorge Pedrozo",
            Platillo = "Spicy Miso (Nivel .NET)",
            Cantidad = 2,
            TipoConsumo = "Para llevar",
            InstruccionesEspeciales = "Picante nivel error de producción. Cubiertos extra."
        },
        new Item 
        { 
            Id = 3,
            Cliente = "Kyojuro Rengoku",
            Platillo = "Shoyu Ramen Clásico",
            Cantidad = 15,
            TipoConsumo = "Para comer aquí",
            InstruccionesEspeciales = "¡UMAI! Servir hirviendo."
        }
    };

    // GET: /Catalogo/Index (Ahora filtra por Platillo)
    public IActionResult Index(string? platillo)
    {
        var resultado = string.IsNullOrEmpty(platillo)
            ? _items
            : _items.Where(i => i.Platillo == platillo).ToList();

        ViewBag.Platillos = _items.Select(i => i.Platillo).Distinct().ToList();
        ViewBag.PlatilloActual = platillo;

        return View(resultado);
    }

    // GET: /Catalogo/Detalle/{id}
    public IActionResult Detalle(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        return item == null ? NotFound() : View(item);
    }

    // GET: /Catalogo/Agregar
    public IActionResult Agregar()
    {
        return View();
    }

    // POST: /Catalogo/Agregar
    [HttpPost]
    public IActionResult Agregar(Item item)
    {
        item.Id = _items.Any() ? _items.Max(i => i.Id) + 1 : 1;
        _items.Add(item);
        return RedirectToAction("Index");
    }
}