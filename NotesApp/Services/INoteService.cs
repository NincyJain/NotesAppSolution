using NotesApp.Models;


namespace NotesApp.Services
{
    public interface INoteService
    {

        List<Note> GetAll(string search);
        Note GetById(int id);
        void Add(Note note);
        void Update(Note note);
        void Delete(int id);

    }
}
