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
    public class Model : IModel {

        private ClientSession _clientSession;
        public ClientSession ClientSession { get { return _clientSession; } set { _clientSession = value; } }

        private ChatData _chatData;
        public ChatData ChatData { get { return _chatData; } set { _chatData = value; } }

        /// <summary>
        /// Model Constructor : Instanciate all dependencies
        /// => Improve drastically Objet Reusability
        /// </summary>
        public Model( ) {
                ChatData = new ChatData( );
        }

        public void CreateSession( ) {
            ClientSession = new ClientSession(
                new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp
                ),
                new IPEndPoint(
                    IPAddress.Parse( ConnexionSettings.IP ),
                    ConnexionSettings.PORT
                )
            );
            ClientSession.Open( );
        }
    }
}
