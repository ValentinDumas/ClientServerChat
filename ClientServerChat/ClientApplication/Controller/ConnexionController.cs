using ClientApplication.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Controller
{
    class ConnexionController : Controller
    {

        private ConnexionControl _connexionControl;

        public ConnexionController(ConnexionControl connexionControl ) {
            _connexionControl = connexionControl;
            InitializeEvents( );
        }

        public void InitializeEvents( ) {

        }


    }
}
