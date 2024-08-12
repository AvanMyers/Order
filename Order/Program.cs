using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int staticNumber = 7;
            int startedNumber = 5;
            string enteredMesage = "";
            string end = "end";
            bool isEnd = false;


            Console.WriteLine($"Сложение будет продолжаться пока вы не напишите {end}");
            Console.WriteLine(startedNumber);

            while(isEnd == false)
            {
                startedNumber += staticNumber;
                Console.WriteLine(startedNumber);
                enteredMesage = Console.ReadLine();

                if (enteredMesage == end)
                {
                    isEnd = true;
                }
            }

            Console.ReadKey();
        }
    }
}
