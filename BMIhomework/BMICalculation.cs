using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIhomework
{
    class BMICalculation
    {
        private double _x; //身高
        private double _y; //體重

        public double x
        {
            get { return _x; }
            set { _x = value; }
        }

        public double y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double add()
        {
         return _y/(_x*_x);

        }

    }
}
