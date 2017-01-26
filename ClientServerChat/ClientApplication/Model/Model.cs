using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClientApplication.Model
{
    class Model : IModel {

        private ClientSession _clientSession;
        public ClientSession ClientSession { get { return _clientSession; } set { _clientSession = value; } }

        // @TODO : ReDo all for IModel;
        private ConnexionData _connexionData;
        public ConnexionData ConnexionData { get { return _connexionData; } set { _connexionData = value; } }

        private ChatData _chatData;
        public ChatData ChatData { get { return _chatData; } set { _chatData = value; } }

        /// <summary>
        /// Model Constructor : Instanciate all dependencies
        /// => Improve drastically Objet Reusability
        /// </summary>
        public Model( ) {
            if(ClientSession == null ) {
                ClientSession = new ClientSession( 
                    new Socket(
                        AddressFamily.InterNetwork,
                        SocketType.Stream,
                        ProtocolType.Tcp
                    ),
                    new IPEndPoint(
                        IPAddress.Parse( ClientSettings.IP ),
                        ClientSettings.PORT
                    )
                );
            }
            if(ConnexionData == null ) {
                ConnexionData = new ConnexionData( );
            }
            if(ChatData == null ) {
                ChatData = new ChatData( );
            }
        }
    }
}
