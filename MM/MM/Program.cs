using System;

namespace MM
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Draw draw = new Draw(n);
            draw.DrawMentorMate();
        }
    }
}