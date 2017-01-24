using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerApplication.Model
{
    public class ClientCommunication
    {
        private Socket _socket;
        public Socket Socket { get { return _socket; } set { _socket = value; } }

        private int _number;
        public int Number { get { return _number; } set { _number = value; } }

        public ClientCommunication( Socket socket, int number ) {
            Socket = socket;
            Number = number;
        }
    }
}
