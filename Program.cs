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
            string[]numberStr = new string[3];
            for (int i = 0; i <=3; i++)
            {
                Console.WriteLine($"{i+1}番目の数字を入力してください >");
                numberStr[i] = Console.ReadLine();

                int number;
                bool result = int.TryParse(numberStr[i], out number);

                if (result == false)
                {
                    Console.WriteLine("\nエラー　数値で入力しろ!");
                }
            }
            Console.WriteLine($"{numberStr[0]},{numberStr[1]},{numberStr[2]},{numberStr[3]}");
            Console.ReadLine();
        }
    }
}
