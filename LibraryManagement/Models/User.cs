using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class User
    {
        private int Id { get; }

        private string Name { get; } = null!;

        private string Address { get; set; } = null!;

        private string PhoneNumber { get; set; } = null!;

        private string Email { get; } = null!;
    }
}
