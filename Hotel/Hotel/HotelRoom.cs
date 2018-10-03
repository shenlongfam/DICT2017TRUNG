using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class HotelRoom
    {
        private int roomNumber;
        private double nightlyRate;

        public HotelRoom(int r)
        {
            roomNumber = r;
            if (r < 300)
                nightlyRate = 69.95;
            else
                nightlyRate = 89.95;
        }
        public double getNightlyRate()
        {
            return nightlyRate;
        }
        public void setNightlyRate(double n)
        {
            nightlyRate = n;
        }
        public int getRoomNumber()
        {
            return roomNumber;
        }
        public void setRoomNumber(int r)
        {
            roomNumber = r;
        }

    }
}
