using HMOproject.Core.Entities;
using HMOproject.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMOproject.Data.Repositories
{
    public class MembersRepository:IMembersRepository
    {
        private readonly DataContext _context;
        public MembersRepository(DataContext context)
        {
            _context = context;
        }

        public  List<Members> GetAllMembers()
        {
            return  _context.MembersList.ToList();
        }

        

        public  Members GetMemberById(int id)
        { 
           return  _context.MembersList.Where(i=>i.CodeMem == id).FirstOrDefault();    
        }

        public  Members AddMember(Members member)
        {
             _context.MembersList.Add(member);
             _context.SaveChanges();
            return member;
        }
        public  void UpdateMember(int id, Members member)
        {
            Members m=GetMemberById(id);
            m.Name = member.Name;
            m.LastName = member.LastName;
            m.Address = member.Address;
            m.Dob = member.Dob;
            m.Phone = member.Phone;
            m.MobilePhone = member.MobilePhone;
            // m.CoronaDetails.Ill=member.CoronaDetails.Ill;
            // m.CoronaDetails.Recovery=member.CoronaDetails.Recovery;
            m.Ill = member.Ill;
            m.Recovery = member.Recovery;
          //  m.countVac = member.countVac;
             _context.SaveChanges();
        }
        public  void DeleteMember(int id)
        {
            //       Members m=GetMemberById(id);
            _context.MembersList.Remove(GetMemberById(id));
         //   _context.MembersList.Remove(m);
            _context.SaveChanges();

        }

       
    }
}
