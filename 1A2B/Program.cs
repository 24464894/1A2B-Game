using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); 
            int ans1 , ans2 , ans3 , ans0;
            ans0 = r.Next(10);
            ans1 = r.Next(10);
            
            while (ans1 == ans0)
            {
                ans1 = r.Next(10);
            }
            ans2 = r.Next(10);
            while (ans2 == ans1 || ans2 == ans0)
            {
                ans2 = r.Next(10);
            }
            ans3 = r.Next(10);
            while (ans3 == ans2 || ans3 == ans1 || ans3 == ans0)
            {
                ans3 = r.Next(10);
            }
            //Console.Write("{0}{1}{2}{3}",ans0, ans1, ans2,ans3);

            Console.WriteLine(" ");
            Console.WriteLine("歡迎來到 1A2B 猜數字的遊戲～");
            int A = 0;
            int B = 0;
            do
            {
                Console.WriteLine("------- ");
                Console.Write("請輸入 4 個數字：");
                int input = int.Parse(Console.ReadLine());
                int thousands = input/1000;
                int hundreds =( input- (thousands*1000))/100;
                int tensdigit = (input - (thousands * 1000)-(hundreds*100))/10;
                int Digits = input - (thousands * 1000) - (hundreds * 100)-(tensdigit*10);
                if (ans0 == thousands)
                {
                    A += 1;
                }
                if (ans0 != thousands)
                {
                    if (ans0 == hundreds || ans0 == tensdigit || ans0 == Digits)
                    {
                        B += 1;
                    }
                }
           
                if (ans1 == hundreds)
                {
                    A += 1;
                }
                if (ans1 != hundreds)
                {
                    if (ans1 == thousands || ans1 == tensdigit || ans1 == Digits)
                    {
                        B += 1;
                    }
                }
                
                if (ans2 == tensdigit)
                {
                    A += 1;
                }
                if (ans2 != tensdigit)
                {
                    if (ans2 == thousands || ans2 == hundreds || ans2 == Digits)
                    {
                        B += 1;
                    }
                }
                
                if (ans3 == Digits)
                {
                    A += 1;
                }
                if (ans3 != Digits)
                {
                    if (ans3 == thousands || ans3 == hundreds || ans3 == tensdigit)
                    {
                        B += 1;
                    }
                }

                Console.WriteLine("判定結果是:{0}A{1}B", A,B);
                
                if(A == 4)
                {
                    Console.WriteLine("恭喜你！猜對了！！"); 
                    Console.WriteLine("你要繼續玩嗎？(y / n):");
                    string closeornot = Console.ReadLine();
                    if(closeornot == "n")
                    {
                        break;
                    }
                }
                A = 0;
                B = 0;
                //
            } while (true);
        }
    }
}
