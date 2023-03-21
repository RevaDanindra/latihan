using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Taxi
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine("OnDuty : Yes");
            }
            else if (OnDuty == false)
            { 
                Console.WriteLine("OnDuty : No");
            }
            Console.WriteLine("Number Of Passenger : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        { 
            Console.WriteLine("\nReva sedang menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("Reva selesai mengantar penumpang");
        }
    }
}
