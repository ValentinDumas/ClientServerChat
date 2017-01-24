using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication.Model
{
    public class Model
    {
        public List<ClientCommunication> clients { get; private set; }

        private ClientCommunication _cc;
        public ClientCommunication Cc { get { return _cc; } set { _cc = value; } }

        public Model( ) {
            clients = new List<ClientCommunication>( );
        }

        public void OpenCommunication( Socket socket, int number) {
            Cc = new ClientCommunication( socket, number );
        }
    }
}
