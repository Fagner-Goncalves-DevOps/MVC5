using Microsoft.AspNetCore.Mvc;
using MVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC5.Controllers
{
    public class CategoriasController : Controller
    {
        public IActionResult Index()
        {
            return View(categorias);
        }

        private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria()
            {
                CategoriaId = 1,
                Nome = "NoteBooks"
            },
            new Categoria()
            {
                CategoriaId = 2,
                Nome ="Monitores"
            },
            new Categoria()
            {
                CategoriaId = 3,
                Nome = "Impressoras"
            },
            new Categoria()
            {
                CategoriaId = 4,
                Nome = "Mouses"
            },
            new Categoria()
            {
                CategoriaId = 5,
                Nome = "Desktops"
            }
        };

    }
}

