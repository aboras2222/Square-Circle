using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp13
{
    public class square
    {
        public int lengthA
        {
            get;
            set;
           
        }

        public int area()
        {

            return (lengthA * 2);
        }

        public int primeter()
        {
            return (lengthA * 4);
        }
        
    }
}