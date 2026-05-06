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
            Titulo = "Devil May Cry",
            Genero = "Hack and Slash",
            Ano = 2001,
            Consola = "PlayStation 2",
            Descripcion = "Videojuego que trata de un cazador..."
        },
        new Item
        {
            Id = 2,
            Titulo = "Castlevania: Symphony of the Night",
            Genero = "Metroidvania",
            Ano = 1997,
            Consola = "PlayStation 1", // Ojo: La imagen dice PS2, pero este es de PS1 originalmente.
            Descripcion = "Videojuego que trata de un cazador..."
        },
        new Item 
        { 
            Id = 3,
            Titulo = "NieR: Automata",
            Genero = "Action RPG",
            Ano = 2017,
            Consola = "PlayStation 4",
            Descripcion = "Una guerra entre androides y máquinas."
        }
    };
    // Parte 3 de 4: Lista con filtro opcional por género
    public IActionResult Index(string? genero)
    {
        var resultado = string.IsNullOrEmpty(genero)
            ? _items
            : _items.Where(i => i.Genero == genero).ToList();

        ViewBag.Generos = _items.Select(i => i.Genero).Distinct().ToList();
        ViewBag.GeneroActual = genero;

        return View(resultado);
    }

    // Detalle
    public IActionResult Detalle(int id)
    {
        var item = _items.FirstOrDefault(i => i.Id == id);
        return item == null ? NotFound() : View(item);
    }

    // Parte 4 de 4: Formulario - GET
    public IActionResult Agregar()
    {
        return View();
    }

    // Formulario - POST
    [HttpPost]
    public IActionResult Agregar(Item item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
        return RedirectToAction("Index");
    }

}