using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Model
{
    public class ClientSession
    {
        private Socket _socket;
        public Socket Socket {
            get {
                return _socket;
            }
            set {
                _socket = value;
            }
        }

        private IPEndPoint _ipEndPoint;
        private NetworkStream _networkStream;

        private TextReader _textReader;
        public TextReader TextReader {
            get {
                return _textReader;
            }
            set {
                _textReader = value;
            }
        }

        private TextWriter _textWriter;
        public TextWriter TextWriter {
            get {
                return _textWriter;
            }
            set {
                _textWriter = value;
            }
        }

        public ClientSession( Socket socket, IPEndPoint ipEndPoint ) {
            Socket = socket;
            this._ipEndPoint = ipEndPoint;
        }

        public void Open( ) {
            // Socket --> Connection to Access Point
            Socket.Connect( this._ipEndPoint );
            _networkStream = new NetworkStream( Socket );
            TextReader = new StreamReader( _networkStream );
            TextWriter = new StreamWriter( _networkStream );
        }

        public void Close( ) {
            // Release the socket.
            Socket.Shutdown( SocketShutdown.Both );
            // Disconnect the socket
            Socket.Disconnect( true );
        }

        // @TODO : Implement this to check if server is up/down
        public bool SocketConnected( Socket s ) {
            bool pool = s.Poll(1000, SelectMode.SelectRead);
            bool availability = (s.Available == 0);
            return (pool && availability);
        }
    }
}
