using HMOproject.Core.Entities;

namespace HMOproject.Core.Repositories
{
    public interface IMembersRepository
    {
        //get all members
        List<Members> GetAllMembers();
        //get member by id
        Members GetMemberById(int id);
        //add member
       Members AddMember(Members members);
        //delete member by id
        void  DeleteMember(int id);
        //update member
        void UpdateMember(int id,Members members);
        
    }
}
