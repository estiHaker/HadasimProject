using HMOproject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO_COVID19.Core.Services
{
    public interface IMembersService
    {
        List<Members> GetMembers();
        Members GetMemberById(int  id);
        Members AddMember(Members member);
        void UpdateMember(int id, Members member);
        void DeleteMember(int id);
    }
}
