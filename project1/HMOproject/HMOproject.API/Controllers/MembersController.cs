using HMO_COVID19.Core.Services;
using HMOproject.API.Models;
using HMOproject.Core.Entities;
using HMOproject.Core.Services;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMOproject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IMembersService _membersService;
        private readonly IVaccinationService _vaccinationService;
        public MembersController(IMembersService membersService,IVaccinationService vaccinationService)
        {
            _membersService = membersService;
            _vaccinationService = vaccinationService;
        }

        // GET: api/<MembersController>
        [HttpGet]
        public List<Members> Get()
        {
            return  _membersService.GetMembers();
        }

        // GET api/<MembersController>/5
        [HttpGet("{id}")]
        public  Members Get(int id)
        {
            return  _membersService.GetMemberById(id);
        }

        // POST api/<MembersController>
        [HttpPost]
        public void  Post([FromBody] MembersPostModel m)
        {
            var memberToAdd = new Members { Name = m.Name, LastName = m.LastName, Id = m.Id, Address = m.Address, Dob = m.Dob, Phone = m.Phone, MobilePhone = m.MobilePhone, countVac = 0 };
             _membersService.AddMember(memberToAdd);
        }

        // PUT api/<MembersController>/5
        [HttpPut("{id}")]
        public  void Put(int id, [FromBody] MemberPutModel m)
        {
            var memberToUupdate = new Members { Name = m.Name, LastName = m.LastName, Id = m.Id, Address = m.Address, Dob = m.Dob, Phone = m.Phone, MobilePhone = m.MobilePhone,Ill=m.Ill,Recovery=m.Recovery };
             _membersService.UpdateMember(id, memberToUupdate);
        }

        // DELETE api/<MembersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
                 _vaccinationService.DeleteAllVaccination(id);
            //if (_membersService.GetMemberById(id) == null)
            //      { return NotFound(); }
            _membersService.DeleteMember(id);
            return Ok();
        }
    }
}
