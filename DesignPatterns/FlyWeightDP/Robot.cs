using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightDP
{
    internal class Robot : IRobot
    {
        String robotType;
        public String colorOfRobot;
        public Robot(String robotType)
        {
            this.robotType = robotType;
        }
        public void SetColor(String colorOfRobot)
        {
            this.colorOfRobot = colorOfRobot;
        }
        public void Print()
        {
            Console.WriteLine("This is a" + robotType + "type robot with" + colorOfRobot + "color");
        }
    }
}
