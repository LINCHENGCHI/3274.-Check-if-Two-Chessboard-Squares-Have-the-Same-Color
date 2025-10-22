using System;

namespace _3274._Check_if_Two_Chessboard_Squares_Have_the_Same_Color
{
    class Program
    {
        static void Main(string[] args)
        {
            string coordinates1 = "a1";
            string coordinates2 = "b1";
            int t1 = coordinates1[0] - 'a' + 1;
            int t2 = coordinates1[1] - '0';
            int t3 = coordinates2[0] - 'a' + 1;
            int t4 = coordinates2[1] - '0';
            if ((t1 + t2) % 2 == (t3 + t4) % 2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
