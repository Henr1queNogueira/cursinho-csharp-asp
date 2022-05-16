using Microsoft.AspNetCore.Mvc;
using SalesWebMvc2.Models;
using System.Collections.Generic;

namespace SalesWebMvc2.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> list = new List<Departament>();
            list.Add(new Departament { Id = 1, Name = "Eletrônicos", Email = "jdfggfdk@gmail.com"});
            list.Add(new Departament { Id = 2, Name = "Fashion", Email = "dds@outlook.com"});
            list.Add(new Departament { Id = 3, Name = "Gamers", Email = "fff@hotmail.com"});


            return View(list);
        }
    }
}
