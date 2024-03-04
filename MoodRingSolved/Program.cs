using static MoodRingSolved.MoodRing;

namespace MoodRingSolved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoodRing mr = new MoodRing();
            Moods m = mr.FindMyMood();
            DrawRing(m);
            Console.ReadKey();
        }

        static void DrawRing(Moods mood) 
        {
            switch (mood)
            {
                case Moods.Default:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case Moods.Creative:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Moods.Romantic:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Moods.Uncertain:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case Moods.Comfortable:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
            Console.WriteLine(@"     __");
            Console.WriteLine(@"    /  \");
            Console.WriteLine(@"   _\  /_");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"  / ____ \");
            Console.WriteLine(@" / /    \ \");
            Console.WriteLine(@"/ /      \ \");
            Console.WriteLine(@"\ \      / /");
            Console.WriteLine(@" \ \____/ /");
            Console.WriteLine(@"  \______/");
        }
    }
}
