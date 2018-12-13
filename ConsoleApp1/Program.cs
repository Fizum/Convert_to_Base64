using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("inserisci una parola da convertire");
            string plainText = Console.ReadLine();
            string base64EncodedData;
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                Console.WriteLine($"{plainText[i]} = {plainTextBytes[i]} = {Convert.ToString(plainTextBytes[i], 2)}");
                
            }

            base64EncodedData = Convert.ToBase64String(plainTextBytes);
            Console.WriteLine(base64EncodedData);

            byte[] base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            plainText = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            Console.WriteLine($"la codifica in base 64 della parola {plainText} è {base64EncodedData}");


            int value = 0;
            Console.WriteLine("inserisci un numero");
            value = Convert.ToInt32(Console.ReadLine());
            char c = Convert.ToChar(value);
            string d = c.ToString();
            Console.WriteLine($"Il numero {value} convertito in ASCII è {d}");

            Console.ReadLine();
        }
    }
}
