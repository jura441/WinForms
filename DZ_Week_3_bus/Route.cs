using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Week_3_bus
{
    internal class Route
    {
        int Busnumber { get; set; }
        string BusType { get; set; }
        string BusDestination { get; set; }
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }

        public Route (int number, string type, string destination, DateTime dateform, TimeSpan timefrom, DateTime dateto, TimeSpan timeto)
        {
            Busnumber = number;
            BusType = type;
            BusDestination = destination;
            DateFrom = dateform;
            DateFrom = DateFrom + timefrom;
            DateTo = dateto;
            DateTo = DateTo + timeto;
        }
        public override string ToString()
        {
            return      Busnumber.ToString() +      "                             |       " + BusType.ToString() + "             |        " + BusDestination.ToString() + "               |       " + DateFrom.ToString() + "              |       " + DateTo.ToString();
        }

        public DateTime getDateTo()
        {
            return DateFrom;
        }
        public DateTime getDateFrom()
        {
            return DateTo;
        }

        public string getBusDestination()
        {
            return BusDestination;
        }
    }
}
