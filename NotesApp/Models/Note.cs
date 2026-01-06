using System.ComponentModel.DataAnnotations;

namespace NotesApp.Models
{
    public class Note
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string Color { get; set; } = "Yellow";

        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
