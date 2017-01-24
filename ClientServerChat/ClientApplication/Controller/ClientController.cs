using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClientApplication.Model;

namespace ClientApplication.Controller
{
    class ClientController : Controller
    {
        public ClientController(ClientWindow clientWindow ) {
            this.clientWindow = clientWindow;
            InitializeEvents( );            
        }

        public void InitializeEvents( ) {
            clientWindow.EventStart += ClientWindow_EventStart;
        }

        private void ClientWindow_EventStart( object sender, EventArgs e ) {
            if ( !ClientSettings.CONNECTED ) {
                model.OpenClientSession( );
                Thread th = new Thread(ListenForResponse);
                th.Start( );
            }
            ClientSettings.CONNECTED = true;
        }

        public void StopEvent( ) {

        }

        private void ListenForResponse( ) {
            while ( true ) {
                string reponse = model.Cs.TextReader.ReadLine();
                // @TOSEE
                clientWindow.print( "HAHA [MVC] IT WORKS !" );
            }
        }

    }
}
