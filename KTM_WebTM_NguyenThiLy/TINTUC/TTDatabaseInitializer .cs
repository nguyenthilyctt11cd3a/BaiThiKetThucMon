using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;using System.Data.Entity;
using KTM_WebTM_NguyenThiLy.TINTUC;

namespace KTM_WebTM_NguyenThiLy
{
    public class BookDatabaseInitializer : DropCreateDatabaseAlways<TTContext>

    {
        protected override void Seed(TTContext context)
        {
            GetCHUDEs().ForEach(c => context.CHUDEs.Add(c));
            GetTinTucs().ForEach(p => context.TinTucs.Add(p));
        }
        private static List<CHUDE> GetCHUDEs()
        {
            var categories = new List<CHUDE>
            {
                new CHUDE
                {
                    CHUDE_ID = 1,
                  TENCD = "ẨM THỰC"
                },
                new CHUDE
                {
                    CHUDE_ID = 2,
                  TENCD = "ĐỜI SỐNG"
                },
                 new CHUDE
                {
                    CHUDE_ID = 3,
                  TENCD = "DU LỊCH"
                },
               
            };
            return categories;
        }
        private static List<TinTuc> GetTinTucs()
        {
            var books = new List<TinTuc> {
                new TinTuc
                {
                    TINTUC_ID = 1,
                    NOIDUNG = "Chân gà xả tắc",
                    NGAYGUI = "Vào những ngày hè nóng nực, một món ăn nhấm nháp cùng bạn bè ngay tại nhà sẽ là một sự lựa chọn rất tốt ",
                    ANH ="chan-ga-sả-tắc-recipe-main-photo.jpg",
                   
                    CHUDE_ID = 1
                    },
              new TinTuc
                {
                    TINTUC_ID = 2,
                    NOIDUNG = "bánh bông lan",
                    NGAYGUI = "bánh bông lan phô mai Đài Loan! Với sự xuất hiện khá cùng thời điểm của hai tiệm bánh là Le Castella và Tai Yang King Castella thì bánh bông lan đã trở thành một món bánh được nhiều người..... ",
                    ANH ="bonglan.jpg",

                    CHUDE_ID = 1
                },
              new TinTuc
                {
                    TINTUC_ID = 3,
                    NOIDUNG = "Bệnh viện bị phạt",
                    NGAYGUI = "Thanh tra Sở Y tế TP.HCM cho biết, vào ngày 11/11 có cuộc làm việc với Viện thẩm mỹ Đại học Y (địa chỉ số 368/7 Nơ Trang Long, phường 13, quận Bình Thạnh, TP.HCM). Tại đây, ông Nguyễn Tiến Thuận chủ cơ sở đã không xuất trình giấy phép hoạt động dịch vụ thẩm mỹ. Vì vậy, đoàn thanh tra Sở Y tế đã tiến hành lập biên bản vi phạm hành chính và tham mưu cho UBND TP.HCM ra quyết định xử phạt. ",
                    ANH ="pttm.jpg",

                    CHUDE_ID = 2 },
               new TinTuc
                {
                    TINTUC_ID = 4,
                    NOIDUNG = "Đia đâu trong hè này?",
                    NGAYGUI = "Vào những ngày hè nóng nực, hãy đi biển cùng bạn bè ngay tại nhà sẽ là một sự lựa chọn rất tốt ",
                    ANH ="bien.png",

                    CHUDE_ID = 3},
              
            };
            return books;
        }
    }
}