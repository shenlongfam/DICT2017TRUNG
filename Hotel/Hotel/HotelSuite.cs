using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class HotelSuite : HotelRoom
    {
        public HotelSuite(int r) : base(r)
        {
            setNightlyRate(getNightlyRate() + 40);
        }
    }
}
