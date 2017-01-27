using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication.View
{
    public class View
    {
        public void print( object input ) {
            if(input != null)
                Console.WriteLine( input.ToString() );
        }
    }
}
