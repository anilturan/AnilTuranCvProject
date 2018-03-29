using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnilTuran.Models
{
    public class Education
    {
        public int EducationID { get; set; }
        public int UserInformationID { get; set; }
        public string Aciklama { get; set; }
        public string OkulAdi { get; set; }
        public string BolumAdi { get; set; }
        public string EgitimSeviyesi { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyy}", ApplyFormatInEditMode = true)]
        public DateTime BaşlamaTarihi { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyy}", ApplyFormatInEditMode = true)]
        public DateTime? BitisTarihi { get; set; }
    }
}