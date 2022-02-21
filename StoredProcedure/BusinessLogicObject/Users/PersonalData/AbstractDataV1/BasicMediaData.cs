using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLogicObject.Users.PersonalData
{
    public abstract class BasicMediaData
    {
        public string imageFile { get; set; }
        public string signatureFile { get; set; }
        public HttpPostedFileBase image { get; set; }
        public HttpPostedFileBase signature { get; set; }
    }
}
