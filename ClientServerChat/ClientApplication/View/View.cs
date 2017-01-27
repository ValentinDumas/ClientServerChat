using ClientApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.View
{
    public class View : IView {

        public IModel Model {get;set;}

        private ChatControl _chatControl;
        public ChatControl ChatControl {
            get {
                return _chatControl;
            }

            set {
                _chatControl = value;
            }
        }

        private ClientWindow _clientWindow;
        public ClientWindow ClientWindow {
            get {
                return _clientWindow;
            }

            set {
                _clientWindow = value;
            }
        }

        private ConnexionControl _connexionControl;
        public ConnexionControl ConnexionControl {
            get {
                return _connexionControl;
            }

            set {
                _connexionControl = value;
            }
        }

        public View( ) {
            if(ClientWindow == null ) {
                ClientWindow = new ClientWindow( );
            }   
            if ( ConnexionControl == null ) {
                ConnexionControl = new ConnexionControl( );
            }   
            if ( ChatControl == null ) {
                ChatControl = new ChatControl( );
            } 
        }
    }
}
