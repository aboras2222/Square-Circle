using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp13
{
    public class rectangle : square
    {
        public int width
        {
            get;
            set;
            
        }
        public int A ()
        {

            return (lengthA * width);
        }

        public int P ()
        {
            return (2*lengthA+2*width);
        }











    }
}