using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication.Controller
{
    class Program
    {
        static void Main( string[] args ) {
            ServerController server = new ServerController();
            server.Start( );
        }
    }
}
