using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change
{
    class Program
    {

        public static int[] changeValues = new int[6] {50, 20, 10, 5, 2, 1};
        public static int[] changeCoins = new int[6];//   50, 20, 10, 5, 2, 1

        static void Main(string[] args)
        {
            bool valid = false;
            float changeFloat = 0;
            int changeInt = 0;

            while (!valid)
            {
                Console.Write("How much change is due?: £");
                string change = Console.ReadLine();
                valid = float.TryParse(change, out changeFloat);
                if (changeFloat <= 0) valid = false;
            }
            changeFloat *= 100;
            changeInt = (int)changeFloat;

            //put the quantity of each coin into changeCoins[]
            for (int i = 0; i < changeValues.Length; i++)
            {
                while (changeInt >= changeValues[i])
                {
                    if (changeInt != changeValues[i])
                    {
                    changeCoins[i] += (changeValues[i] % changeInt) / changeValues[i];
                    changeInt -= changeValues[i];
                    } else
                    {
                        changeCoins[i]++;
                        changeInt -= changeValues[i];
                    }
                }
            }

            //Write changeCoins to output stream
            for (int i = 0; i < changeCoins.Length; i++)
            {
                Console.Write(changeCoins[i]);
                Console.WriteLine("x" + changeValues[i] + "p");

            }

            Console.ReadKey();
        }
    }
}
//like WTF is happening...
//seriously