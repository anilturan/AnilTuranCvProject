using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnilTuran.Models
{
    public class Skill
    {
        public int SkillID { get; set; }
        public int UserInformationID { get; set; }
        public string BeceriAdi { get; set; }
        public string BeceriDerecesi { get; set; }
        public string Aciklama { get; set; }
    }
}