using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    abstract class IShape
    {
        
        public string Color { get; set; }
        public abstract void Area();
        public abstract void GetColor();
    }
}
