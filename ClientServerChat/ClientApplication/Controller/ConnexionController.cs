using ClientApplication.View;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApplication.Model;
using System.Threading;

namespace ClientApplication.Controller
{
    public class ConnexionController : Controller
    {
        private ConnexionControl _connexionControl;
        private ChatControl _chatControl;
        private string reponse = String.Empty;
        Thread th;

        public ConnexionController( ConnexionControl connexionControl ) {
            _connexionControl = connexionControl;
            InitializeEvents( );
        }

        public void InitializeEvents( ) {
            _connexionControl.EventConnexion += _connexionControl_EventConnexion;
        }

        private void _connexionControl_EventConnexion( object sender, EventArgs e ) {
            
            ConnexionSettings.PSEUDO = _connexionControl.textBoxPseudo.Text.ToString( );
            ConnexionSettings.IP = _connexionControl.textBoxServerIp.Text.ToString( );
           
            if ( ConnexionSettings.PSEUDO.Equals(String.Empty) || ConnexionSettings.IP.Equals(String.Empty) ) {
                Console.WriteLine( "Veuillez remplir tous les champs !" );
                _connexionControl.labelField.Visibility = Visibility.Visible;
            } else {
                if ( _chatControl == null ) {
                    _chatControl = new ChatControl( );
                    _connexionControl.gridChat.Children.Add( _chatControl );
                    _chatControl.EventLeave += ChatControl_EventLeave;
                    _chatControl.EventSend += ChatControl_EventSend;
                }

                _connexionControl.gridConnexion.Visibility = Visibility.Hidden;
                _connexionControl.gridChat.Visibility = Visibility.Visible;
                _connexionControl.labelField.Visibility = Visibility.Hidden;

                /**/
                if ( !ConnexionSettings.CONNECTED ) {
                    Model.CreateSession( );
                    th = new Thread(ListenForResponse);
                    th.Start( );
                }
                ConnexionSettings.CONNECTED = true;
                /**/
            }
        }

        private void ListenForResponse( ) {
            while ( true ) {
                string reponse = Model.ClientSession.TextReader.ReadLine();
                Console.WriteLine( reponse );
                Application.Current.Dispatcher.Invoke( new Action<string>( Display ), reponse ); // Invoke Afficher !
            }
        }

        private void Display( string obj ) {
            _chatControl.textBlockChat.Text += Environment.NewLine + obj;
        }

        private void ChatControl_EventLeave( object sender, EventArgs e ) {
            if(_connexionControl != null ) {
                _connexionControl.gridChat.Visibility = Visibility.Hidden;
                _connexionControl.gridConnexion.Visibility = Visibility.Visible;
            }
            /*
            ConnexionSettings.CONNECTED = false;
            Model.ClientSession.Close( );
            */
        }

        private void ChatControl_EventSend( object sender, EventArgs e ) {
            Model.ChatData.Message = _chatControl.textBoxMessage.Text.ToString( );

            if ( Model.ChatData.Message != String.Empty ) {
                _chatControl.labelMessage.Visibility = Visibility.Hidden;
                
                if(reponse != String.Empty ) {
                    _chatControl.textBlockChat.Text += Environment.NewLine + reponse;
                }

                string message = ConnexionSettings.PSEUDO + "> " + Model.ChatData.Message;
                Model.ClientSession.TextWriter.WriteLine( message );
                Model.ClientSession.TextWriter.Flush( );

            } else {
                _chatControl.labelMessage.Visibility = Visibility.Visible;
            }
            _chatControl.textBoxMessage.Clear( );
        }
    }
}
