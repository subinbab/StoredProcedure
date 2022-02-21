using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObject.Users.PersonalData
{
    public abstract  class BasicRegistrationData
    {
        public int id { get; set; }
        public string name { get; set; }
        public long adharNumber { get; set; }
        public long phoneNumber { get; set; }
        public string email { get; set; }
    }
}
