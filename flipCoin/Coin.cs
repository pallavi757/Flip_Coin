using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flipCoin
{
    public class Coin
    {
        int Headper = 0;
        int Tailper = 0;
        int Head = 0;
        int Tail = 0;

        public void Show()
        {
            Console.WriteLine("Enter how many times flip the coin");
            int time = int.Parse(Console.ReadLine());
            for (int i = 0; i < time; i++)
            {
                Random random = new Random();
                int toss = random.Next(0, 1);
                if (toss >0.5)
                {
                    Head++;
                }
                if (toss < 0.5)
                {
                    Tail++;
                }

            }
            Headper = Head / time * 100;
            Console.WriteLine("total head:" + Head + ",Per of head:" + Headper);
            Tailper = Tail / time * 100;
            Console.WriteLine("total tai:" + Tail + ",Per of tail:" + Tailper);
        }
    }
}
