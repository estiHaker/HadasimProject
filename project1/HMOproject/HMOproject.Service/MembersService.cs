using HMO_COVID19.Core.Services;
using HMOproject.Core.Entities;
using HMOproject.Core.Repositories;
using HMOproject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO_COVID19.Service
{
    public class MembersService: IMembersService
    {
        private readonly IMembersRepository _membersRepository;
        public MembersService(IMembersRepository membersRepository)
        {
            _membersRepository = membersRepository;
        }
        public List<Members> GetMembers()
        {
            return  _membersRepository.GetAllMembers();
        }

        public Members GetMemberById(int id)
        {
            return   _membersRepository.GetMemberById(id);
        }
        public Members AddMember(Members member)
        {
            if(Validation.isMember(member))
            {
                    _membersRepository.AddMember(member);
            }
            return member;
            
           
        }

        public void UpdateMember(int  id, Members member)
        {
            if (Validation.isMemberUpdate(member))
            {
                 _membersRepository.UpdateMember(id, member);
            }
            
        }
        public  void DeleteMember(int id)
        {
             _membersRepository.DeleteMember(id);
        }
    }
}
