using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;

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
            return View();
        }

        public IActionResult Create( Registro objProducto)
        {
            _context.Add(objProducto);
            _context.SaveChanges();
            ViewData["Message"] = "El producto ha sido registrado";

            return View("Index");
        }
    }
}