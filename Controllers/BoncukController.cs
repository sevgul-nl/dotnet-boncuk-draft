using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using eBoncuk.Models;
using System.Runtime.CompilerServices;

namespace eBoncuk.Controllers
{
    public class BoncukController : Controller
    {
        public IActionResult Detail(string id)
        {
            Boncuk boncuk = Data.GetBoncuk(id);
            return View(boncuk);
        }

        public IActionResult List()
        {
            List<Boncuk> boncuks = Data.GetBoncuks();
            return View(boncuks);
        }
    }
}