using System;

namespace _3274._Check_if_Two_Chessboard_Squares_Have_the_Same_Color
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入座標1:");  //輸出輸入座標1提示
            string coordinates1 = Console.ReadLine(); //使用者輸入座標1指定給字串資料型別coordinates1
            
            Console.WriteLine("輸入座標2:"); //輸出輸入座標2提示
            string coordinates2 = Console.ReadLine(); //使用者輸入座標2指定給字串資料型別coordinates2

            
            int t1 = coordinates1[0] - 'a' + 1; // 將第一個座標的字母部分轉換成數字
            int t2 = coordinates1[1] - '0'; // 將第一個座標的數字部分轉換成整數
            int t3 = coordinates2[0] - 'a' + 1; // 將第二個座標的字母部分轉換成數字
            int t4 = coordinates2[1] - '0'; // 將第二個座標的數字部分轉換成整數
            if ((t1 + t2) % 2 == (t3 + t4) % 2)// 判斷兩個格子顏色是否相同。(t1+t2)%2計算第一個格子的顏色 (奇數=白, 偶數=黑)，(t3+t4)%2 計算第二個格子的顏色
            {
                Console.WriteLine("true"); // 顏色相同，輸出 true
            }
            else
            {
                Console.WriteLine("false"); // 顏色不同，輸出 false
            }
        }
    }
}


