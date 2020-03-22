using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstapp
{
    interface IShape
    {
        double X { get; set; }
        double Y { get; set; }

        void draw();
    }
}
