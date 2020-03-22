using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstapp
{
    class Square : IShape
    {
        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }


        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        void IShape.draw()
        {
            try
            {
                for (int i = 0; i < 12; i++)
                {
                    int l = i + 1;
                }

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}
