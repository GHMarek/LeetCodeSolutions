using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLibrary
{
    public class DesignParkingSystem
    {

        int[] parkingLot = new int[3];
        public DesignParkingSystem(int big, int medium, int small)
        {
            parkingLot[0] = big;
            parkingLot[1] = medium;
            parkingLot[2] = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (parkingLot[0] > 0)
                    {
                        parkingLot[0]--;
                        return true;
                    }
                    return false;
                case 2:
                    if (parkingLot[1] > 0)
                    {
                        parkingLot[1]--;
                        return true;
                    }
                    return false;
                case 3:
                    if (parkingLot[2] > 0)
                    {
                        parkingLot[2]--;
                        return true;
                    }
                    return false;
                default:
                    return false;
            }



        }
    }
}
