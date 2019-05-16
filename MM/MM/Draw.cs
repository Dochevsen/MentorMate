using System;

namespace MM
{
    class Draw
    {
        private int startingPoint;
        private string line;
        private string dash;
        private string dashMiddle;
        private string star;
        private string starMiddle;
        private int dashAfterMiddle;
        private int starAfterMiddle;

        public Draw(int n)
        {
            startingPoint = n;
            dashAfterMiddle = 1;
            starAfterMiddle = startingPoint - 1;
            dash = new string('-', startingPoint);
            dashMiddle = new string('-', startingPoint);
            star = new string('*', startingPoint);
            starMiddle = new string('*', 0);
        }

        private void DrawFirstLine()
        {
            line = dash + star + dashMiddle + star + dash + dash + star + dashMiddle + star + dash;
            Console.WriteLine(line);
        }

        private void DrawAfterFirstLine()
        {
            for (int i = 1; i < startingPoint + 1; i++)
            {
                if (i < (startingPoint + 1) / 2)
                {
                    dash = new string('-', startingPoint - i);
                    star = new string('*', startingPoint + i * 2);
                    dashMiddle = new string('-', startingPoint - i * 2);
                    line = dash + star + dashMiddle + star + dash + dash + star + dashMiddle + star + dash;
                    Console.WriteLine(line);
                }

                else if (i >= (startingPoint + 1) / 2)
                {
                    dash = new string('-', (startingPoint - i));
                    star = new string('*', startingPoint);
                    dashMiddle = new string('-', dashAfterMiddle);
                    starMiddle = new string('*', startingPoint + starAfterMiddle);
                    line = dash + star + dashMiddle + starMiddle + dashMiddle + star + dash + dash + star + dashMiddle + starMiddle + dashMiddle + star + dash;
                    Console.WriteLine(line);
                    dashAfterMiddle += 2;
                    starAfterMiddle -= 2;
                }
            }
        }

        public void DrawMentorMate()
        {
            DrawFirstLine();
            DrawAfterFirstLine();
        }
    }
}
