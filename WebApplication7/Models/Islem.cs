using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class Islem

    {
        public int IslemId { get; set; }
        public int islemTuru { get; set; }
        public String odemeAraci { get; set; }
        public String aciklama { get; set; }
        public double tutar { get; set; }
    }
}