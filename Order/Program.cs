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
            int lastNumber = 103;
            bool isEnd = false;


            Console.WriteLine($"Сложение будет продолжаться пока не достигнет числа  {lastNumber}");
            Console.Write(startedNumber + " ");

            while(isEnd == false)
            {
                startedNumber += staticNumber;
                Console.Write(startedNumber + " ");

                if (startedNumber == lastNumber)
                {
                    isEnd = true;
                }
            }

            Console.ReadKey();
        }
    }
}
