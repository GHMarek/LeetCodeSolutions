using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class MinimumAmountOfTimeToCollectGarbage
    {
        public int GarbageCollection(string[] garbage, int[] travel)
        {

            int[] metalTruck = new int[2];
            int[] paperTruck = new int[2];
            int[] glassTruck = new int[2];

            for (int i = 0; i < garbage.Length; i++)
            {
                for (int j = 0; j < garbage[i].Length; j++)
                {

                    if (i == 0)
                    {
                        switch (garbage[i][j])
                        {
                            case 'M':
                                metalTruck[0] += 1;
                                break;

                            case 'P':
                                paperTruck[0] += 1;
                                break;

                            case 'G':
                                glassTruck[0] += 1;
                                break;
                        }

                        continue;
                    }

                    switch (garbage[i][j])
                    {
                        case 'M':
                            metalTruck[0] += 1 + (Enumerable.Range(metalTruck[1], i - metalTruck[1]).Select(x => travel[x]).Sum());
                            metalTruck[1] = i;
                            break;

                        case 'P':
                            paperTruck[0] += 1 + (Enumerable.Range(paperTruck[1], i - paperTruck[1]).Select(x => travel[x]).Sum());
                            paperTruck[1] = i;
                            break;

                        case 'G':
                            glassTruck[0] += 1 + (Enumerable.Range(glassTruck[1], i - glassTruck[1]).Select(x => travel[x]).Sum());
                            glassTruck[1] = i;
                            break;
                    }
                }

            }

            return metalTruck[0] + paperTruck[0] + glassTruck[0];
        }
    }
}

