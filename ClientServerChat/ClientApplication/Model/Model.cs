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
    class Model
    {
        private ClientSession _cs;
        public ClientSession Cs { get { return _cs; } set { _cs = value; } }
        
        /// <summary>
        /// Instantiate a ClientSession object and Open a new session
        /// </summary>
        public void OpenClientSession( ) {
            Cs = new ClientSession(
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

        /// <summary>
        /// Close Client Session and dispose resources
        /// </summary>
        public void CloseClientSession( ) {
            Cs.Close( );
        }
    }
}
