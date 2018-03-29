using AnilTuran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnilTuran.DTO
{
    public class ExperienceDTO
    {
        public Experience Deneyim { get; set; }
        public UserInformation User { get; set; }
        public virtual ICollection<Experience> Deneyimler { get; set; }
        public virtual ICollection<UserInformation> UserInformations { get; set; }

    }
}