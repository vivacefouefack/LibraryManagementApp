using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Models
{
    public class Loan
    {
        [Key]
        private int Id { get; }

        private DateTime LoanDate { get; }

        private DateTime ReturnDate { get; }


        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; private set; } = null!;


        [ForeignKey("Member")]
        public int MemberId { get; set; }
        public Member Member { get; private set; } = null!;
    }
}
