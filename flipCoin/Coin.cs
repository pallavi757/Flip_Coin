using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flipCoin
{
    public class Coin
    {
        float Headper = 0.0f;
        float Tailper = 0.0f;
        int Head = 0;
        int Tail = 0;

        public void Show()
        {
            Console.WriteLine("Enter how many times flip the coin");
            int time = int.Parse(Console.ReadLine());
            for (int i = 0; i < time; i++)
            {
                Random random = new Random();
                int toss = random.Next(0, 2);
                if (toss < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
                

            }
            Headper = (float)Head * 100 / time;
            Console.WriteLine("total head:" + Head + ",Per of head:" + Headper);
            Tailper = (float)Tail * 100 / time;
            Console.WriteLine("total tail:" + Tail + ",Per of tail:" + Tailper);
        }
    }
}
