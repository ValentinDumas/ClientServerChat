using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Controller
{
    abstract class Controller
    {
        public ClientWindow clientWindow;
        public Model.Model model;
        public Controller( ) {
            model = new Model.Model( );
        }
    }
}
