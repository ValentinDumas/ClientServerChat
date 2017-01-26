using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClientApplication.Model;
using ClientApplication.View;

namespace ClientApplication.Controller
{
    class ClientController : Controller
    {
        private ClientWindow _clientWindow;

        public ClientController( ClientWindow clientWindow ) {
            _clientWindow = clientWindow;
            InitializeEvents( );            
        }

        public void InitializeEvents( ) {
            _clientWindow.EventStart += ClientWindow_EventStart;
        }

        private void ClientWindow_EventStart( object sender, EventArgs e ) {
            if ( !ClientSettings.CONNECTED ) {
                Model.ClientSession.Open( );
                Thread th = new Thread(ListenForResponse);
                th.Start( );
            }
            ClientSettings.CONNECTED = true;
        }

        public void EventStop( ) {
            Model.ClientSession.Close( );
        }

        private void ListenForResponse( ) {
            while ( true ) {
                string reponse = Model.ClientSession.TextReader.ReadLine();
                // @TOSEE
                // clientWindow.print( "HAHA [MVC] IT WORKS !" );
            }
        }

    }
}
