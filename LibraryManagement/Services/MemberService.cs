using LibraryManagement.Dto;
using LibraryManagement.Interfaces;
using LibraryManagement.Models;

namespace LibraryManagement.Services
{
    public class MemberService : IMember
    {
        public Task<List<Loan>> ConsultHistory(int idMember)
        {
            throw new NotImplementedException();
        }

        public Task<MemberDto> Subscribe(MemberDto memberData)
        {
            throw new NotImplementedException();
        }

        public Task<int> Unsubscribe(int idMember)
        {
            throw new NotImplementedException();
        }
    }
}
