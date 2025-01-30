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
            string[]numberStr = new string[4];
            int []number = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i+1}番目の数字を入力してください >");
                numberStr[i] = Console.ReadLine();

                bool result = int.TryParse(numberStr[i], out number[i]);

                if (result == false)
                {
                    Console.WriteLine("\nエラー　数値で入力しろ!");
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

            Console.ReadLine();
        }
    }
}
