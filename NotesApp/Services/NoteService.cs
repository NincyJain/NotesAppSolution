using NotesApp.Data;
using NotesApp.Models;
using System.Collections;

namespace NotesApp.Services
{
    public class NoteService: INoteService
    {
        private readonly AppDbContext _context;

        public NoteService(AppDbContext context)
        {
            _context = context;
        }
        public List<Note> GetAll(string search)
        {
            var notes = _context.Notes.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                notes = notes.Where(n =>
                    n.Title.ToLower().Contains(search) ||
                    n.Description.ToLower().Contains(search));
            }
            return notes.ToList();
            

        }
        public Note GetById(int id)
        {
            return _context.Notes.FirstOrDefault(n => n.Id == id);
            
        }
        public void Add(Note note)
        {
            _context.Notes.Add(note);
            _context.SaveChanges();
        }
        public void Update(Note note)
        {
            _context.Notes.Update(note);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            var note = _context.Notes.Find(id);
            if (note != null)
            {
                _context.Notes.Remove(note);
                _context.SaveChanges();
            }

        }

       
    }
}
