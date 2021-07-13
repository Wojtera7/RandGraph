using System;

namespace RandGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            bool condition = true;
            int[] container = new int[10];
            int limit = 50;

            while (condition)
            {
                System.Threading.Thread.Sleep(12);
                int dice = rand.Next(0, 9);

                switch (dice)
                {
                    case 0:
                        container[0]++;
                        break;
                    case 1:
                        container[1]++;
                        break;
                    case 2:
                        container[2]++;
                        break;
                    case 3:
                        container[3]++;
                        break;
                    case 4:
                        container[4]++;
                        break;
                    case 5:
                        container[5]++;
                        break;
                    case 6:
                        container[6]++;
                        break;
                    case 7:
                        container[7]++;
                        break;
                    case 8:
                        container[8]++;
                        break;
                    case 9:
                        container[9]++;
                        break;
                }

                Console.Clear();

                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < container[i]; j += 2)
                    {
                        Console.Write(".");
                    }

                    Console.WriteLine("");

                    for (int k = 1; k < container[i]; k += 2)
                    {
                        Console.Write("'");
                    }

                    Console.WriteLine("");
                }

                foreach (int i in container)
                {
                    if (i >= limit)
                    {
                        condition = false;
                    }
                }

            }

        }
    }
}
