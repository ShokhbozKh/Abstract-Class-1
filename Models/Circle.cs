using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Circle : IShape
    {
        public decimal Raduis { get; set; }
        public override void Area()
        {
            Console.WriteLine($"Yuzi: {(decimal)Math.PI * Raduis * Raduis}");
        }

        public override void GetColor()
        {
            Console.WriteLine($"Rangi:{Color}");
        }
    }
}
