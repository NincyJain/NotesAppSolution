using Microsoft.AspNetCore.Mvc;
using NotesApp.Data;
using NotesApp.Models;
using NotesApp.Services;

namespace NotesApp.Controllers
{
    public class NotesController : Controller
    {
        private readonly INoteService _service;

        public NotesController(INoteService service)
        {
            _service = service;
        }



        // /Notes/Index
        public IActionResult Index(string search)
        {
            var notes = _service.GetAll(search);
            return View(notes);
        }

        public IActionResult AddNotes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNotes(Note note)
        {
            if (!ModelState.IsValid)
                return View(note);

            _service.Add(note);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return Json(new { success = true });
        }


        [HttpPost]
        public IActionResult EditNotes(Note note)
        {
            if(!ModelState.IsValid)
            {
                return Json(new { success = false });
            }
            _service.Update(note);

            return Json(new { success = true });
            

           
        }

        [HttpGet]
        public IActionResult GetNote(int id)
        {
            var note = _service.GetById(id);

            if (note == null)
                return NotFound();
            

            return Json(note);
        }
    }
}
