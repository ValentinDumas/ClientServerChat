using ClientApplication.Model;
using ClientApplication.View;

namespace ClientApplication.Controller
{
    public class Controller
    {
        private IModel _model;
        public IModel Model { get { return _model; } set { _model = value; } }

        public Controller( ) {
            if(Model == null ) {
                Model = new Model.Model( );
            }     
        }
    }
}
