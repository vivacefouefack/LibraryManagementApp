using LibraryManagement.Dto;
using LibraryManagement.Models;

namespace LibraryManagement.Interfaces
{
    public interface IMember
    {
        public Task<MemberDto> Subscribe(MemberDto memberData);

        public Task<int> Unsubscribe(int idMember);

        public Task<List<Loan>> ConsultHistory(int idMember);
    }
}
