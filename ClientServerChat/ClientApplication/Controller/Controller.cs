using ClientApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Controller
{
    abstract class Controller
    {
        private ClientWindow _clientWindow;
        public ClientWindow ClientWindow { get { return _clientWindow; } set { _clientWindow = value; } }

        private IModel _model;
        public IModel Model { get { return _model; } set { _model = value; } }

        public Controller( ) {
            Model = new Model.Model( );
        }
    }
}
