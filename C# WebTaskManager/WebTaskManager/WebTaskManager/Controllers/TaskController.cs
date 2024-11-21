using Microsoft.AspNetCore.Mvc;
using WebTaskManager.Data;
using WebTaskManager.Models;

namespace WebTaskManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly AppDbContext _context;

        public TaskController(AppDbContext context)
        {
            _context = context;
        }

        // Anzeigen der Aufgaben
        public IActionResult Index()
        {
            var tasks = _context.Tasks.ToList();
            return View("~/Views/Home/Index.cshtml", tasks); // Pfad für Index-View
        }

        // GET: Neue Aufgabe hinzufügen
        public IActionResult Create()
        {
            return View("~/Views/Home/Create.cshtml"); // Pfad für Create-View
        }

        // POST: Neue Aufgabe speichern
        [HttpPost]
        public IActionResult Create(TaskModel task)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(task); // Neue Aufgabe hinzufügen
                _context.SaveChanges();  // Änderungen speichern
                return RedirectToAction("Index"); // Zurück zur Aufgabenübersicht
            }
            return View("~/Views/Home/Create.cshtml", task); // Fehlerhafte Eingaben erneut anzeigen
        }

        // Aufgabe löschen
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                _context.Tasks.Remove(task); // Aufgabe entfernen
                _context.SaveChanges();     // Änderungen speichern
            }
            return RedirectToAction("Index");
        }

        // Aufgabe als erledigt markieren
        [HttpPost]

        public IActionResult MarkAsDone(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null)
            {
                // Toggle den Wert von IsCompleted
                task.IsCompleted = !task.IsCompleted;
                _context.SaveChanges(); // Änderungen speichern
            }
            return RedirectToAction("Index");
        }
    }
}
