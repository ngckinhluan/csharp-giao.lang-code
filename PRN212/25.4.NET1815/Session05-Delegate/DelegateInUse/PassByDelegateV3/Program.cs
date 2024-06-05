namespace PassByDelegateV3
{
    // C#5: IN RA LỜI CỦA 2 BÀI HÁT THÔNG QUA TRUYỀN HÀM IN BÀI HÁT VÀO 1 HÀM IN TẬP TRUNG;
    // 1 HÀM CHỊU TRÁCH NHIỆM THẦU / 1 CÁI HUB TRUNG TÂM  NHẬN CÁC LỆNH IN KHÁC NHAU !!!
    // 
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSongLyricsThe1(); // () gọi hàm run đi
            PrintSongLyricsLover(); // tên hàm 1 mình ên -> luật sư = thân chủ
            // em ủy quyền anh, anh gọi em là luật sư đó
            Console.WriteLine("C#5: CALL 2 EXPLICIT METHODS VIA DELEGATE VAR");
            Action f = PrintSongLyricsThe1;
            //f += PrintSongLyricsLover;
            f(); // multicast delegate
            // BIẾN  =  VALUE; là tên hàm!!!
            // int x = 2003;
            Console.WriteLine("\n\nC#5: CALL 2 EXPLICIT METHODS AS TRADITIONAL \n");
            PrintOnDemand(); // RUN HÀM CHÍNH ON DEMAND() THÌ 2 HÀM CON BÊN TRONG ĐƯỢC RUN()
           Console.WriteLine("\n\nC#6: PRINT ON DEMAND - DEPENDENCY INJECTION");
            PrintOnDemand(() => Console.WriteLine("I love Uyên Nhi <3 SS180823"));
            
            PrintOnDemand(PrintSongLyricsAugust);
            PrintOnDemand(PrintSongLyricsThe1);
            // HÀM NGOÀI ĐC TRUYỀN VÀO HÀM CHÍNH POD()
            // 1 LOGIC XỬ LÍ BÊN NGOÀI ĐC PASS VÀO BÊN TRONG HÀM CHÍNH POD()
            // HÀM TRUYỀN VÀO HÀM CHÍNH QUA NGÃ THAM SỐ => LẬP TRÌNH HÀM - FUNCTIONAL PROGRAMMING
            // HÀM TRUYỀN VÀO HÀM CHÍNH QUA NGÃ THAM SỐ => HÀM CHÍNH LÀM GÌ THÌ LÀM ĐI NHỚ GỌI HÀM QUA NGẢ THAM SỐ SAU KHI CHÁN CHÊ
            // CALL BACK FUNCTION
            // JAVA: CÓ LAMBDA EX
            //       TRUYỀN HÀM VÀO HÀM PHẢI BAO CÀI HÀM LẠI TRONG 1 INTERFACE CHỈ CÓ DUY NHẤT 1 HÀM - INTERFACE CHỈ CÓ DUY NHẤT 1 HÀM GỌI LÀ @Functional Interface
            //         DÙNG KÈM KĨ THUẬT ANONYMOUS CLASS
            // ĐỪNG NHẦM LẪN PASS HÀM VÀO HÀM VỚI PASS 1 OBJECT STUDENT S VÀO 1 HÀM
            // void PrintOnDemand(Student s) // truyền tham chiếu, truyền nhiều hàm của OBJECT; KO TRUYỀN HÀM ĐƠN NHƯ MÌNH ĐANG HỌC!!! KO LAMBDA VÀ DELEGATE GÌ CẢ
            // KO CALLBACK GÌ CẢ
            Action fxxx = PrintSongLyricsThe1;
            fxxx += PrintSongLyricsLover;
            fxxx += PrintSongLyricsAugust;
            // Gọi HÀM CHÍNH, DEPENDENCY INJECTION - TAO CHÍCH VÀO HÀM CHÍNH 3 CÁI HÀM KHÁC
            PrintOnDemand(fxxx); // 3 HÀM CHẠY NHƯ LÚC HARD-CODE
            // C#6: TUI MÚN IN BÀI HÁT TIẾP THEO CỦA TAYLOR: CAROLINA
            // CHƠI QUAN IN DỊCH VỤ
            PrintOnDemand(PrintSongLyricsLover);
            PrintOnDemand(() => Console.WriteLine("I Love Uyên Nhi! <3"));
            // C#6: HÃY IN RA CÁC SỐ TỪ 1...100
            PrintOnDemand(() => {
                for (int i = 1; i <= 1000; i++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            });



        }
        //---------------------------------------------
        // em phục vụ in ấn theo nhu cầu của các bác
        // các bác mún in thế nào, nói em, đưa cho em em in cho

        // ---------------------------------------
        static void PrintOnDemand() // HÀM CHÍNH RUN THÌ 2 HÀM CON ĐC RUN
        {
            Console.WriteLine("The main-method code...code...");
            Console.WriteLine("The main-method code...code...");
            Console.WriteLine("Call 2 sub-method to print...");
            PrintSongLyricsThe1(); // 2 HÀM CON ĐC RUN
            PrintSongLyricsLover();
            PrintSongLyricsAugust();
            // TIGHT COUPLING - HÀM CHÍNH PrintOnDemand() phụ thuộc vào 3 hàm
            // hard-code luôn. SAU NÀY MUỐN IN BÀI KHÁC, 1 BÀI KHÁC THÌ PHẢI SỬA CODE TRỰC TIẾP TIGHT COUPLING
            // CÓ CÁCH HAY HƠN: IN GÌ THÌ ĐƯA VÀO, TRONG HÀM CHÍNH PrintOnDemand chỉ có lệnh in đúng cái đưa vào, ĐƯA VÀO GÌ IN CÁI ĐÓ, KO HARD-CODE GÌ CẢ
            // GÌ CẢ -> LOOSE COUPLING - RÀNG BUỘC LỎNG LẼO, FLEXIBLE VỚI BÊN NGOÀI, ADAPTIVE VỚI BÊN NGOÀI ĐƯA VÔ THAY VÌ MÌNH GẮN CỨNG VỚI THỨ ĐÃ LÀM SẴN
            // BÊN NGOÀI ĐƯA VÔ THAY VÌ MÌNH GẮN CỨNG VỚI THỨ ĐÃ LÀM SẴN
            // TUI - PRINTONDEMAND() KO GẮN HARD-CDODE VỚI TÊN HÀM NÀO CẢ, MUỐN LÀM GÌ THÌ ĐƯA VÀO TÊN HÀM BÊN GOÀI VÀO ĐÂY, TAO IN CHO, TAO GỌI CHO
            // TƯ DUY NÀY LÀ TƯ DUY STYLE: KIẾN TRÚC SƯ PHẦN MỀM - SOLUTION ARCHITECT - SA
            // LƯƠNG ĐỘ PHÂN GIẢI 4K / MONTH Ở VIỆT NAM.
        }
        public static void PrintSongLyricsThe1()
        {
            Console.WriteLine("The song The 1 - by Taylor Swift");
            Console.WriteLine(@"I'm doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made
...
"); // verbatim
        }
        public static void PrintSongLyricsLover()
        {
            Console.WriteLine("The song Blinding Light - by The Weeknd");
            Console.WriteLine();
            Console.WriteLine(@"I've been tryna call
I've been on my own for long enough
Maybe you can show me how to love, maybe
I'm goin' through withdrawals
You don't even have to do too much
You can turn me on with just a touch, baby

[Pre-Chorus]
I look around and
Sin City's cold and empty (Oh)
No one's around to judge me (Oh)
I can't see clearly when you're gone

[Chorus]
I said, ooh, I'm blinded by the lights
No, I can't sleep until I feel your touch
I said, ooh, I'm drowning in the night
Oh, when I'm like this, you're the one I trust
Hey, hey, hey
");
        }
        static void PrintOnDemand(Action f) // HÀM CHÍNH RUN THÌ 2 HÀM CON ĐC RUN, HIỆN TƯỢNG OVERLOAD / OVERLOADING
        {
            Console.WriteLine("The main-method code...code...");
            Console.WriteLine("The main-method code...code...");
            Console.WriteLine("Call any outside method passed into...");
            Console.WriteLine("For now I'm flexible to receive your request");
            Console.WriteLine("Tell me what do you want, I call it / do it for you");
            f();
          
            // RUN BẤT KÌ HÀM NÀO ĐƯA VÀO QUA NGÃ HAM SỐ
            // giống 3 run hàm cũ Hard_code ở dưới 
            // NAY ĐƯA TÊN HÀM MUỐN RUN QUA NGÃ THAM SỐ
            // ĐƯA TỪNG 3 THẰNG Ở DƯỚI QUA NGẢ THAM SỐ, 3 HÀM VẪN ĐC RUN NHƯ CŨ!!!
            // NHƯNG NAY CÒN RUN ĐC HÀM BẤT KÌ MIỄN LÀ GỬI QUA THAM SỐ ACTION ĐÚNG ĐỊNH DẠNG FORMAT ĐÚNG STYLE HÀM
            // LOOSE COUPLING
            // DEPENDENCY INJECTION: CHÍCH VÀO CHO EM 1 CÁI HÀM KHÁC BÊN NGOÀI QUA NGÃ THAM SỐ
            // CHÍCH / PASS HÀM NÓ, RUN HÀM ĐÓ

            //PrintSongLyricsThe1(); // 3 HÀM HARD-CODE, TIGHT COUPLING
            //PrintSongLyricsLover();
            //PrintSongLyricsAugust(); / GỌI CHUNG NÓ LÀ CHỮ F TỪ BÊN TRÊN ĐƯA VÀO
            // TIGHT COUPLING - HÀM CHÍNH PrintOnDemand() phụ thuộc vào 3 hàm
            // hard-code luôn. SAU NÀY MUỐN IN BÀI KHÁC, 1 BÀI KHÁC THÌ PHẢI SỬA CODE TRỰC TIẾP TIGHT COUPLING
            // CÓ CÁCH HAY HƠN: IN GÌ THÌ ĐƯA VÀO, TRONG HÀM CHÍNH PrintOnDemand chỉ có lệnh in đúng cái đưa vào, ĐƯA VÀO GÌ IN CÁI ĐÓ, KO HARD-CODE GÌ CẢ
            // GÌ CẢ -> LOOSE COUPLING - RÀNG BUỘC LỎNG LẼO, FLEXIBLE VỚI BÊN NGOÀI, ADAPTIVE VỚI BÊN NGOÀI ĐƯA VÔ THAY VÌ MÌNH GẮN CỨNG VỚI THỨ ĐÃ LÀM SẴN
            // BÊN NGOÀI ĐƯA VÔ THAY VÌ MÌNH GẮN CỨNG VỚI THỨ ĐÃ LÀM SẴN
            // TUI - PRINTONDEMAND() KO GẮN HARD-CDODE VỚI TÊN HÀM NÀO CẢ, MUỐN LÀM GÌ THÌ ĐƯA VÀO TÊN HÀM BÊN GOÀI VÀO ĐÂY, TAO IN CHO, TAO GỌI CHO
            // TƯ DUY NÀY LÀ TƯ DUY STYLE: KIẾN TRÚC SƯ PHẦN MỀM - SOLUTION ARCHITECT - SA
            // LƯƠNG ĐỘ PHÂN GIẢI 4K / MONTH Ở VIỆT NAM.
        }
        public static void PrintSongLyricsAugust()
        {
            Console.WriteLine(@"I miss the tates of a swetter life
I miss the conversation
I'm searching for a song tonight
I'm changing all of the stations
I like to think that we had it all
We drew a map to a better place
But on that road I took a fall
Oh baby why did you run away?
I was there for you in your darkest times
I was there for you in your darkest nights
But I wonder where were you
 When I was at my worst
Down on my knees
And you said you had my back
So I wonder where were you
All the roads you took came back to me
So I'm following the map that leads to you
The map that leads to you
Ain't nothing I can do
The map that leads to you
Following, following, following to you
The map that leads to you
Ain't nothing I can do
The map that leads to you
Following, following, following");
        }
    }



    

}
