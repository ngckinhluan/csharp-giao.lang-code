using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveStory
{
    // 3 THẰNG NGANG CƠ NHAU, ĐỨNG NGANG HÀNG NHAU: * INTERFACE,
    // * CLASS (TAO CHỨA INFO CỦA OBJECT NGOÀI ĐỜI, HÀNH ĐỘNG )
    // * DELEGATE  (CLASS ĐẶC BIỆT - TAO CHỈ CHỨA TÊN HÀM)
    //public class X [void X()] delegate
    //{
    //    _nickHamNaoDo = ???
    //}

    public delegate void SendLoveMessageDelegate(); // delegate void X
    // Bạn: void NhanEm(); f
    // Tui: void TellHer(); x
    internal class CuKia
    {
        public static void MeetSweetHeart()
        {
            Console.WriteLine("Hey baby, oh my sweet heart!");
            // hắn CuKia phải nhận lời gửi gắm của Tui và Bạn -> chính là trỏ đến hàm nhắn tin mà lẻ ra Tui Ban phải trực tiếp run, trực tiếp nói, nay CuKia sẽ RUN GIÙM, DELEGATE CHO CUKIA, CHO NICKNAME, TAO CHUYỂN LỜI CỦA TAO CHO MÀY RUN
            //SendLoveMessageDelegate message = new SendLoveMessageDelegate(Tui.TellHer);
            SendLoveMessageDelegate message = new Tui().TellHer;
            message += Ban.NhanEm;
            Console.WriteLine("By the way, you have messages from...");
            // gọi hàm nhắn tin, nhưng ko gọi trực tiếp mà gọi qua delegate do 2 tin này capture dưới dạng biến delegate, bỏ vào vùng new Delegate
            // gọi gián tiếp, nói giùm, ủy quyền
            message(); // em nghe 2 message nè

            // trực tiếp sẽ là: Tui.TellHer() Bạn.NhanEm()

        }
    }
}
