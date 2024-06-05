namespace PassByDelegateV1
{
    // CHALLENGE #1: IN RA 2 LỜI BÀI HÁT NÀO ĐÓ CỦA TAYLOR SWIFT: THE 1, LOVER
    //               LÀM THEO STYLE TRUYỀN THỐNG
    // CHALLENGE #2: DÙNG DELEGATE ĐỂ IN BÀI HÁT
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#1: Call explicit method as normal directly - Call hàm có sẵn");
            PrintSongLyricsThe1();
            PrintSongLyricsLover(); // gọi hàm run có dấu ()
            Console.WriteLine("C#2: Call explicit methods using delegate");
            //PrintSongLyricsThe1();
            //PrintSongLyricsLover();
            // style Action - void F()
            Action f1 = () =>
            {
                Console.WriteLine("The song The 1 - by Taylor Swift");
                Console.WriteLine(@"I'm doing good, I'm on some new shit
Been saying ""yes"" instead of ""no""
I thought I saw you at the bus stop, I didn't though
I hit the ground running each night
I hit the Sunday matinée
You know the greatest films of all time were never made
...
");
            };
            f1();
            Action f2 = PrintSongLyricsThe1; // luật sư = thân chủ; HỢP ĐỒNG ỦY QUYỀN
            f2.Invoke();
            f2 += PrintSongLyricsLover; // += nối thêm bài, trò 2 hàm
            // 1 luật sư = 2 hay nhiều thân chủ
            // multicast delegate
            f2.Invoke(); // run 2 hàm lẻ; đừng quên ngoặc tròn () run hàm

            // C#3: IN RA THÊM 2 BÀI HÁT NỮA, KO ĐC TẠO HÀM LẺ CÓ SẴN RỒI GÁN MÀ DÙNG HÀM ẨN DANH VÀ BIỂU THỨC LAMBDA
           Action f3 = () =>
{
    Console.WriteLine("The song lyrics August - by Taylor Swift");
    Console.WriteLine();
    Console.WriteLine(@"[Verse 1: Chris Martin]
I've been reading books of old
The legends and the myths
Achilles and his gold
Hercules and his gifts
Spider-Man's control
And Batman with his fists
And clearly I don't see myself upon that list");
}; // VIP
            Action f5 = () =>
            {
                Console.WriteLine("The song lyrics August - by Taylor Swift");
                Console.WriteLine();
                Console.WriteLine(@"[Verse 1: Chris Martin]
I've been reading books of old
The legends and the myths
Achilles and his gold
Hercules and his gifts
Spider-Man's control
And Batman with his fists
And clearly I don't see myself upon that list");
            }; // VIP
            Action f4 = () =>
            {
                Console.WriteLine("The song lyrics August - by Taylor Swift");
                Console.WriteLine();
                Console.WriteLine(@"[Verse 1: Chris Martin]
I've been reading books of old
The legends and the myths
Achilles and his gold
Hercules and his gifts
Spider-Man's control
And Batman with his fists
And clearly I don't see myself upon that list");
            }; // VIP - CHỈ LÀ HỢP ĐỒNG LUẬT SƯ = THÂN CHỦ = HÀM ẨN DANH THAY VÌ CÓ SẴN
            Console.WriteLine("C#3: Call ANONYMOUS / LAMBDA EXPRESSION methods");
            f2();
            f3();

        }


        static void PrintSongLyricsThe1()
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
        static void PrintSongLyricsLover()
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
    }
}
