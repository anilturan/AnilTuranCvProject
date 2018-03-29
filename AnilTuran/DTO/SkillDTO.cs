using AnilTuran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnilTuran.DTO
{
    public class SkillDTO
    {


        public int SkillID { get; set; }
        public int UserInformationID { get; set; }
        public string BeceriAdi { get; set; }
        public string BeceriDerecesi { get; set; }
        public string Aciklama { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Skill Yetenek { get; set; }
        public UserInformation User { get; set; }
        public virtual ICollection<Skill> Yetenekler { get; set; }
        public virtual ICollection<UserInformation> UserInformations { get; set; }
        
   
    }
}