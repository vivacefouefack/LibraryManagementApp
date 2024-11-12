using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class User
    {
        private int Id { get; }

        private string name { get; } = null!;

        private string address { get; set; } = null!;

        private string phoneNumber { get; set; } = null!;

        private string email { get; } = null!;
    }
}
