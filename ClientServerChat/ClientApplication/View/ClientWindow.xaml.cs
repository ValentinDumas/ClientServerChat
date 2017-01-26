using ClientApplication.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace ClientApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        public ClientWindow( ) {
            InitializeComponent( );
            new ClientController( this );
            InitializeEvents( );
        }

        public void InitializeEvents( ) {

        }

        #region ButtonStart_Click Event
        public delegate void EventHandlerStart( object sender, EventArgs e );
        public event EventHandlerStart EventStart;
        private void ButtonStart_Click( object sender, RoutedEventArgs e ) {
            EventStart?.Invoke( this, EventArgs.Empty );
        }
        #endregion


    }
}
