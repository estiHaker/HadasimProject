using HMOproject.Core.Entities;

namespace HMOproject.API.Models
{
    public class MembersPostModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public int countVac { get; set; } = 0;
    }
}
