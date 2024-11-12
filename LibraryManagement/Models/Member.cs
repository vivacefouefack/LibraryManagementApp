using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Member : User
    {
        [Key]
        private int Id { get; }

        private List<Loan> HistoryLoans { get; }

        public Member():base()
        {
            this.HistoryLoans = new List<Loan>();
        }
    }
}
