using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace KTM_WebTM_NguyenThiLy.TINTUC
{
    public class TinTuc
    {
        [ScaffoldColumn(false)]
        public int TINTUC_ID { get; set; }
        [Required, StringLength(100), Display(Name = "TINTUC")]
        public string NOIDUNG { get; set; }
       
        //public string Description { get; set; }
        public string NGAYGUI { get; set; }
        public string ANH{ get; set; }
       
        public int? CHUDE_ID { get; set; }
        public virtual CHUDE Category { get; set; }
    }
}