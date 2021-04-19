using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen_Testing
{
    class Field
    {

        public Point Coordinates { get; set; }
        public string Ground { get; set; }

        public Field(Point coordinates, string ground)
        {

            Coordinates = coordinates;
            Ground = ground;

        }
    }


}

