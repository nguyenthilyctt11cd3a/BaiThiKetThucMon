//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.ComponentModel.DataAnnotations;

//namespace KTM_WebTM_NguyenThiLy.DaTa
//{
//    public class TACGIA
//    {

//        [ScaffoldColumn(false)]
//        public int TGIA_ID { get; set; }
//        [Required, StringLength(100), Display(Name = "TENTG")]
//        public string TENTG { get; set; }
//        [Required, StringLength(100), Display(Name = "EMAIL")]
//        public int EMAIL { get; set; }
//        [Required, StringLength(100)]
//        public virtual ICollection<TinTuc> TinTuC { get; set; }
//    }
//}