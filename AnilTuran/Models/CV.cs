using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnilTuran.Models
{
    public class CV
    {
        public int Id { get; set; }
        public string CvAdi { get; set; }
        public string CvYolu { get; set; }
        public bool AktifMi { get; set; }
    }
}