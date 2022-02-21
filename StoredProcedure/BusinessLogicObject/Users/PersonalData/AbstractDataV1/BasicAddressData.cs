using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObject.Users.PersonalData
{
    public abstract class BasicAddressData
    {
        public string address { get; set; }
        public string cityOrDistrict { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string zipCode { get; set; }
    }
}
