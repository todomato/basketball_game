using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Calculater
    {
        public int Ways(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            else
            {
                var r = Ways(n - 1) + Ways(n - 2) + 1;
                return r;
            }


        }
    }
}
