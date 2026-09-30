using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class IndustrialRobot : RobotPrototype
    {
        public string IndustrialTask;

        public IndustrialRobot(string modelName, string batteryCapacity,
            string softwareVersion, string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            this.IndustrialTask = industrialTask;
        }

        public override RobotPrototype Clone()
        {
            return new IndustrialRobot(this.modelName, this.batteryCapacity,
                this.softwareVersion, this.IndustrialTask);
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"IndustrialRobot: {modelName} Battery: {batteryCapacity} hrs " +
                              $"Software: {softwareVersion} Task: {IndustrialTask}");
        }
    }
}
