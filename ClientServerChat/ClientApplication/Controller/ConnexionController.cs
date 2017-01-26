using ClientApplication.View;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Controller
{
    class ConnexionController : Controller
    {
        private ConnexionControl _connexionControl; // Connexion View
        private ChatControl _chatControl;           // Chat View

        private Model.ConnexionData _connexionData; // Connexion Model

        public ConnexionController( ConnexionControl connexionControl ) {
            _connexionControl = connexionControl;
            InitializeEvents( );
        }

        public void InitializeEvents( ) {
            _connexionControl.EventConnexion += _connexionControl_EventConnexion;
        }

        private void _connexionControl_EventConnexion( object sender, EventArgs e ) {
            _connexionData = new Model.ConnexionData( );
            
            _connexionData.Pseudo   = _connexionControl.textBoxPseudo.Text.ToString( );
            _connexionData.ServerIp = _connexionControl.textBoxServerIp.Text.ToString( );

            // begin Visibilities !
            if ( _chatControl == null ) {
                _chatControl = new ChatControl( );
            }

            if ( _connexionData.Pseudo == "" ) {
                Console.WriteLine( "Veuillez remplir tous les champs !" );
            } else {
                Console.WriteLine( "Tous les champs sont remplis ! OK !" );
                Console.WriteLine( "Pseudo = " + _connexionData.Pseudo );
                Console.WriteLine( "Pseudo = " + _connexionData.ServerIp );
                _connexionControl.gridConnexion.Visibility = Visibility.Hidden;
                _connexionControl.gridChat.Visibility = Visibility.Visible;
            }
        }
    }
}
