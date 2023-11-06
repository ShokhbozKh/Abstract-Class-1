using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Rectangle : IShape
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        
        public override void Area()
        {
            Console.WriteLine("Yuzi :"+Length*Width);
        }

        public override void GetColor()
        {
            Console.WriteLine("Color: " + Color);
        }
    }
}
