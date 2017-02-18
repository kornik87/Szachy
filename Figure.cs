using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy
{
    public class Figure
    {
        private string shape;
        private string color;

        public string Shape 
        { 
            get { return shape; }
            set { shape = value; }
        }
        public string Color 
        { 
            get { return color; }
            set { color = value; }
        }

        public Figure()
        {
            Shape = null;
            Color = null;
        }

    }
}
