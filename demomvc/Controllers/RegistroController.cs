using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;
using System.Linq;

namespace demomvc.Controllers
{
    public class RegistroController: Controller
    {
        private readonly ApplicationDbContext _context;

        public RegistroController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.DataProductos.ToList());
        }
         public IActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        public IActionResult Create( Registro objProducto)
        {
            _context.Add(objProducto);
            _context.SaveChanges();
            ViewData["Message"] = "El producto ha sido registrado!!!";

            return View();
        }

        public IActionResult Edit(int id)
        {
            Registro objProducto = _context.DataProductos.Find(id);
            if(objProducto==null){
                return NotFound();
            }
            return View(objProducto);
        } 

        [HttpPost]
         public IActionResult Edit(int id,[Bind("id,producto,nombre,categoria,precio,descuento")] Registro objProducto)
         {
             _context.Update(objProducto);
             _context.SaveChanges();
              ViewData["Message"] = "El contacto ha sido actualizado!!!";
             return View(objProducto);
         }

         public IActionResult Delete(int id)
        {
            Registro objProducto = _context.DataProductos.Find(id);
            _context.DataProductos.Remove(objProducto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}