using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KTM_WebTM_NguyenThiLy.TINTUC

{
    public class CHUDE
    {

        [ScaffoldColumn(false)]
        public int CHUDE_ID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string TENCD { get; set; }
        public virtual ICollection<TinTuc> Books { get; set; }
    }
    }