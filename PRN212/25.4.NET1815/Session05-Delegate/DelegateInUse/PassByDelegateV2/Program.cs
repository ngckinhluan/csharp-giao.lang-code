namespace PassByDelegateV2
{
    internal class ShowBiz
    {
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

        public void PrintSongLyricsLover()
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

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#4: CALL THE METHODS OUTSIDE - IN ANOTHER CLASS");
            Action f1 = ShowBiz.PrintSongLyricsThe1;
            ShowBiz song = new ShowBiz();
            Action f2 = song.PrintSongLyricsLover;
            Action f3 = new ShowBiz().PrintSongLyricsLover;
            // NGUYÊN LÍ DẤU =, A =, B =
            // Ở ĐÂU XÀI A ĐC THÌ Ở ĐÓ XÀI B
            f1.Invoke();
            f2.Invoke();
            f3.Invoke(); // IN LẠI LOVER 2 LẦN
        }
    }
}
