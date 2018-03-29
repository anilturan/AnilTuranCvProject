using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnilTuran.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjeAdi { get; set; }
        public string Aciklama { get; set; }
        public string Link { get; set; }
        public int UserInformationID { get; set; }
    }
}