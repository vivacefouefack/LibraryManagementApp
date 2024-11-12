using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Manager : User
    {
        [Key]
        private int Id { get; }

        private string Role { get; set; } = null!;
    }
}
