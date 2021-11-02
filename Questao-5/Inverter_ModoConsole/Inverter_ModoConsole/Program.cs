using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverter_ModoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str2;
            char[] arr;
            int i;

            Console.Write("Digite o texto: ");
            str = Console.ReadLine();

            Console.WriteLine();

            str2 = new string(str.ToLower().Reverse().ToArray());

            arr = str2.ToCharArray(0, str2.Length);

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                {
                    Console.Write(arr[i] + " ");
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
