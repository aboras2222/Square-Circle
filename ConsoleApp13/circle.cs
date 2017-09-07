using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp13
{
    public class circle : square

    {
        private double pi = 3.14;

        public double R
        {
            get;
            set;


        }
       
        public double AC ()
        {
            return (pi*R*R);
        }
    }
   

}