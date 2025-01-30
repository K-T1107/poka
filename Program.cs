using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] numberStr = new string[4];
                int[] number = new int[4];
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"{i + 1}番目の数字を1～13の間で入力してください >");
                    numberStr[i] = Console.ReadLine();

                    bool result = int.TryParse(numberStr[i], out number[i]);

                    if (result == false)
                    {
                        Console.WriteLine("\nエラー　数値で入力しろ!");
                    }
                    if(number[i] >= 14)
                    {
                        Console.WriteLine("\nエラー　1～13で入力しろ!");
                    }
                    if (number[i] <= 0)
                    {
                        Console.WriteLine("\nエラー　1～13で入力しろ!");
                    }
                }

                //ペアの判定
                int count = 0;
                for (int i = 0; i < number.Count() - 1; i++)
                {
                    for (int j = i + 1; j < number.Count(); j++)
                    {
                        if ((number[i] & 0xF) == (number[j] & 0xF))
                        {
                            count++;
                        }
                    }
                }

                // 成立した役を返す
                switch (count)
                {
                    case 0:
                        Console.WriteLine("\nノーペア");
                        break;
                    case 1:
                        Console.WriteLine("\nワンペア");
                        break;
                    case 2:
                        Console.WriteLine("\nツーペア");
                        break;
                    case 3:
                        Console.WriteLine("\nスリーカード");
                        break;
                    case 6:
                        Console.WriteLine("\nフォーカード");
                        break;
                }

                Console.WriteLine("もう一回やんの？おれヤダ");
                Console.WriteLine("1.やらせてください, 2.帰る");
                string answerStr = Console.ReadLine();
                bool result1 = int.TryParse(answerStr, out int answer);

                if (result1 == false)
                {
                    Console.WriteLine("\nエラー　数値で入力しろ!");
                }

                if (answer == 1)
                {
                    Console.WriteLine("マジでもっかいやんの？");
                    Console.WriteLine("1.やらせてください, 2.帰る");
                    string answer2Str = Console.ReadLine();
                    bool result2 = int.TryParse(answer2Str, out int answer2);

                    if (result2 == false)
                    {
                        Console.WriteLine("\nエラー　数値で入力しろ!");
                    }

                    if (answer2 == 1)
                    {
                        Console.WriteLine("チッ");
                        Console.Read();
                    }
                    if (answer2 == 2)
                    {
                        Console.WriteLine("二度と来るな");
                        Console.Read();
                        break;
                    }
                }
                else if (answer == 2) 
                {
                    Console.WriteLine("二度と来るな");
                    Console.Read();
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
