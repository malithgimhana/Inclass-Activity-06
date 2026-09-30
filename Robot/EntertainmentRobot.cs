using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class EntertainmentRobot : RobotPrototype
    {
        public string EntertainmentFeature;

        public EntertainmentRobot(string modelName, string batteryCapacity,
            string softwareVersion, string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.EntertainmentFeature = entertainmentFeature;
        }

        public override RobotPrototype Clone()
        {
            return new EntertainmentRobot(this.modelName, this.batteryCapacity,
                this.softwareVersion, this.EntertainmentFeature);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"EntertainmentRobot: {modelName} Battery: {batteryCapacity} hrs " +
                              $"Software: {softwareVersion} Feature: {EntertainmentFeature}");
        }
    }
}
