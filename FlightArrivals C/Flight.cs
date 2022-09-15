using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightArrivals_C
{
    public class Flight : IComparable<Flight>
    {
        public string FlightNo;
        public string DepartName;
        public string ArrivalTime;

        public Flight(string flNo, string dep, string time)
        {
            FlightNo = flNo;
            DepartName = dep;
            ArrivalTime = time;
        }

        public override string ToString()
        {
            return String.Format("{0,-15}{1,-15}{2,-10}", FlightNo, DepartName, ArrivalTime);
        }

        //Flight objects will be sorted on arrival time
        public int CompareTo(Flight f)
        {
            if (string.Compare(this.ArrivalTime, f.ArrivalTime) > 0)
            {
                return 1;
            }
            else if (string.Compare(this.ArrivalTime, f.ArrivalTime) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
