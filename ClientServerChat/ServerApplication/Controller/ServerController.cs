using ServerApplication.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerApplication.Controller
{
    class ServerController : Controller
    {

        public ServerController( ){
            model = new Model.Model( );
            view = new View.View( );
        }

        public void Start( ) {
            Socket serverSocket = new Socket( 
                AddressFamily.InterNetwork, 
                SocketType.Stream, 
                ProtocolType.Tcp);
            IPEndPoint ipEndPoint = new IPEndPoint(
                IPAddress.Parse(ServerSettings.IP),
                ServerSettings.PORT
                );
            serverSocket.Bind( ipEndPoint );
            serverSocket.Listen( ServerSettings.MAXCLIENTS ); /* @param nbMaxDeConnexionsEnAttente */

            // 5 - Gestion des connexions client et socket
            while ( ServerSettings.ISPOWERED ) {
                view.print( "Attente d'une connexion..." );
                
                Socket socket = serverSocket.Accept();
                ++(ServerSettings.NBCLIENTS);
                model.OpenCommunication(socket, ServerSettings.NBCLIENTS);
                model.clients.Add( model.Cc );

                Thread th = new Thread(ListenForClients); // Délégate <-- Appel à la méthode Communication ?
                th.Start( model.Cc );
            }
        }

        // Attente de la réponse du client --> Contenu variable pour chaque serveur propre
        private void ListenForClients( Object o ) {
            // Etablissement réseau Stream (chaine de caractères)
            ClientCommunication cc = (ClientCommunication) o;
            NetworkStream networkStream = new NetworkStream( cc.Socket );
            TextReader textReader = new StreamReader(networkStream);        // <=> RECEIVE
            TextWriter textWriter = new StreamWriter(networkStream);        // <=> SEND

            view.print( "Connexion du Client n°" + cc.Number );
            // Envoi des données (au client) depuis le buffer
            textWriter.WriteLine( "Vous êtes le client n°" + cc.Number );
            textWriter.Flush( );

            string ip = cc.Socket.RemoteEndPoint.ToString(); // Addresse IP du client distant
            view.print( "IP Client = " + ip );

            while ( true ) {
                string request = "Client " + cc.Number + " >" + textReader.ReadLine( );
                view.print( request );
                broadcast( request );
                textWriter.Flush( );
            }
        }

        // Requête de broadcast à tous les clients connectés
        public void broadcast( string input ) {
            foreach ( ClientCommunication cc in model.clients ) {
                Socket s = cc.Socket;
                NetworkStream ns = new NetworkStream(s);
                TextWriter tw = new StreamWriter(ns);
                tw.WriteLine( input );
                tw.Flush( );
            }
        }


    }
}
