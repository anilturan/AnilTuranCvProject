using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnilTuran.Models
{
    public class UserInformation
    {
        public UserInformation()
        {
            Unvanlar = new HashSet<Unvan>();
            Yetenekler = new HashSet<Skill>();
            Projeler = new HashSet<Project>();
            Egitimler = new HashSet<Education>();
            Deneyimler = new HashSet<Experience>();
        }
        public int UserInformationID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumYeri { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Hakkimda { get; set; }
        public string Link1 { get; set; }
        public string Link2 { get; set; }
        public virtual ICollection<Unvan> Unvanlar { get; set; }
        public virtual ICollection<Skill> Yetenekler { get; set; }
        public virtual ICollection<Project> Projeler { get; set; }
        public virtual ICollection<Education> Egitimler { get; set; }
        public virtual ICollection<Experience> Deneyimler { get; set; }
        public virtual CV CV { get; set; }
    }
}