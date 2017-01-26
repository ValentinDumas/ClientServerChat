using ClientApplication.View;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Controller
{
    class ConnexionController : Controller {
        private ConnexionControl _connexionControl;
        public ChatControl _chatControl{get; set;}

        public ConnexionController( ConnexionControl connexionControl) {
            _connexionControl = connexionControl;
            InitializeEvents( );
        }

        public void InitializeEvents( ) {
            _connexionControl.EventConnexion += _connexionControl_EventConnexion;
        }

        private void _connexionControl_EventConnexion( object sender, EventArgs e ) {
           
            Model.ConnexionData.Pseudo = _connexionControl.textBoxPseudo.Text.ToString( );
            Model.ConnexionData.ServerIp = _connexionControl.textBoxServerIp.Text.ToString( );
           
            if ( Model.ConnexionData.Pseudo.Equals("") || Model.ConnexionData.ServerIp.Equals("") ) {
                Console.WriteLine( "Veuillez remplir tous les champs !" );
                _connexionControl.labelField.Visibility = Visibility.Visible;
            } else {
                if ( _chatControl == null ) {
                    _chatControl = new ChatControl( );
                    _connexionControl.gridChat.Children.Add( _chatControl );
                    _chatControl.EventLeave += ChatControl_EventLeave;
                }
                _connexionControl.gridConnexion.Visibility = Visibility.Hidden;
                _connexionControl.gridChat.Visibility = Visibility.Visible;
                _connexionControl.labelField.Visibility = Visibility.Hidden;
            }  
        }

        private void ChatControl_EventLeave( object sender, EventArgs e ) {
            if(_connexionControl != null ) {
                _connexionControl.gridChat.Visibility = Visibility.Hidden;
                _connexionControl.gridConnexion.Visibility = Visibility.Visible;
            }
        }
    }
}
