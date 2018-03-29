
using AnilTuran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnilTuran.DTO
{
    public class UnvanDTO
    {
        public Unvan Unvan { get; set; }
        public UserInformation User { get; set; }
        public virtual ICollection<UserInformation> UserInformations { get; set; }
        public virtual ICollection<Unvan> Unvanlar { get; set; }
    }
}