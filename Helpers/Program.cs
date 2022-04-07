using System;

namespace Helpers
{
    public static class Helper
    {
        public static void P(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void S(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
        }

        public static void P(Action click)
        {
            Console.WriteLine(click);
        }
    }
}
