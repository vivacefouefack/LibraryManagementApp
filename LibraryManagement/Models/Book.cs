using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Key]
        private int Id { get; }

        private string Isbn { get; set; } = null!;

        private string Title { get; set; } = null!;

        private string Author { get; set; } = null!;

        private string Gender { get; set; } = null!;

        private DateTime PublicationDate { get; set; }

        private int Copies { get; set; }

        private bool Borrowed { get; set; }
    }
}
