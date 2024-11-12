using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Member : User
    {
        [Key]
        private int Id { get; }
    }
}
