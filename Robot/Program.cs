using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Program
    {
        public static void Main(String[] args)
        {
            ServiceRobot sr1 = new ServiceRobot("CareBot", "10", "v1.0", "Patient assistance");
            sr1.DisplayDetails();

            ServiceRobot sr2 = (ServiceRobot)sr1.Clone();
            sr2.batteryCapacity = "15";
            sr2.softwareVersion = "v1.1";
            sr2.DisplayDetails();

            Console.WriteLine();

            IndustrialRobot ir1 = new IndustrialRobot("WelderBot", "12", "v2.0", "Welding");
            ir1.DisplayDetails();

            IndustrialRobot ir2 = (IndustrialRobot)ir1.Clone();
            ir2.IndustrialTask = "Assembly";
            ir2.softwareVersion = "v2.1";
            ir2.DisplayDetails();

            Console.WriteLine();

            EntertainmentRobot er1 = new EntertainmentRobot("FunBot", "8", "v3.0", "Dancing");
            er1.DisplayDetails();

            EntertainmentRobot er2 = (EntertainmentRobot)er1.Clone();
            er2.EntertainmentFeature = "Singing";
            er2.batteryCapacity = "12";
            er2.DisplayDetails();
        }
    }
}
