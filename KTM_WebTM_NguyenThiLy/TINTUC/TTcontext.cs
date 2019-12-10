using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace KTM_WebTM_NguyenThiLy.TINTUC
{
    public class TTContext: DbContext
    {
        public TTContext() : base("TINTUC")
        { }
        public DbSet<CHUDE> CHUDEs { get; set; }
        public DbSet<TinTuc> TinTucs { get; set; }
        //public DbSet<CartItem> ShoppingCartItems { get; set; }


    }
}