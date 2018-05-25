using ClientApplication.Controller;
using ClientApplication.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientApplication.View
{
    /// <summary>
    /// Interaction logic for ConnexionControl.xaml
    /// </summary>
    public partial class ConnexionControl : UserControl
    {
        private ConnexionController _c = null;
        
        public ConnexionControl( ) {            
            InitializeComponent( );
            _c = new ConnexionController( this );
            InitializeUIEvents( );
        }

        public void InitializeUIEvents( ) {
            buttonConnexion.Click += ButtonConnexion_Click;
            Application.Current.Exit += OnAppExit;
        }

        public void OnAppExit(object sender, EventArgs e)
        {
            _c.Stop();
            Application.Current.Shutdown();
        }

        #region Event Handler Connexion (Start)
        public delegate void EventHandlerConnexion( object sender, EventArgs e );
        public event EventHandlerConnexion EventConnexion;
        private void ButtonConnexion_Click( object sender, RoutedEventArgs e ) {
                EventConnexion?.Invoke( this, EventArgs.Empty );
        }
        #endregion

    }
}
