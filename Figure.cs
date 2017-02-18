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
        private string name;

        public string Shape 
        { 
            get { return shape; }
            set {                 
                if (value == " i ")
                name = "pion";
                else if (value == "/-\\")
                name = "goniec";
                else if (value == " % ")
                name = "kon";
                else if (value == "|\"|")
                name = "wierza";
                else if (value == "/*\\")
                name = "krolowa";
                else if (value == "I*I")
                name = "krol";

                shape = value; 
            }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Name
        {
            get { return name; }
        }

        public Figure()
        {
            Shape = null;
            Color = null;
        }       
    }
}
