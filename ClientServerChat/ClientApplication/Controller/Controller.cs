using ClientApplication.Model;
using ClientApplication.View;

namespace ClientApplication.Controller
{
    public class Controller : IController
    {
        //public ClientWindow _clientWindow { get; set; }
        public IModel Model { get; set; }

        public Controller( ) {
            if ( Model == null )
                Model = new Model.Model( );
        }
    }
}
