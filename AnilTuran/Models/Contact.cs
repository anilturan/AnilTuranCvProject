using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnilTuran.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Isim { get; set; }
        public string Email { get; set; }
        public string Mesaj { get; set; }
    }
}