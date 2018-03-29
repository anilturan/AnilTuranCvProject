using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnilTuran.Models
{
    public class Experience
    {
        public int ExperienceID { get; set; }
        public int UserInformationID { get; set; }
        public string PozisyonAdi { get; set; }
        public string SirketAdi { get; set; }
        public string Aciklama { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BaslamaTarihi { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? BitisTarihi { get; set; }
    }
}