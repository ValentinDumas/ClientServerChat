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
    class ClientSession
    {
        private Socket _socket;
        private IPEndPoint _ipEndPoint;
        private NetworkStream _networkStream;

        private TextReader _textReader;
        public TextReader TextReader { get { return _textReader; } set { _textReader = value; } }

        private TextWriter _textWriter;
        public TextWriter TextWriter { get { return _textWriter; } set { _textWriter = value; } }

        public ClientSession( Socket socket, IPEndPoint ipEndPoint ) {
            this._socket = socket;
            this._ipEndPoint = ipEndPoint;
            // Socket --> Connection to Access Point
            Open( );
        }

        public void Open( ) {
            this._socket.Connect( this._ipEndPoint );
            _networkStream = new NetworkStream( this._socket );
            TextReader = new StreamReader( _networkStream );
            TextWriter = new StreamWriter( _networkStream );
        }

        public void Close( ) {
            // Release the socket.
            this._socket.Shutdown( SocketShutdown.Both );
            // Disconnect the socket
            this._socket.Disconnect( true );
        }

        
    }
}
