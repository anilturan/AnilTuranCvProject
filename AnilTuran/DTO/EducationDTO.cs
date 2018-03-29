using AnilTuran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnilTuran.DTO
{
    public class EducationDTO
    {
        public Education Egitim { get; set; }
        public UserInformation User { get; set; }
        public virtual ICollection<UserInformation> UserInformations { get; set; }
        public virtual ICollection<Education> Egitimler { get; set; }
    }
}