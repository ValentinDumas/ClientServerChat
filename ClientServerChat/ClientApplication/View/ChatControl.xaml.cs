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

namespace ClientApplication.View
{
    /// <summary>
    /// Interaction logic for ChatControl.xaml
    /// </summary>
    public partial class ChatControl : UserControl
    {
        
        public ChatControl( ) {
            InitializeComponent( );
            InitializeEvents( );
            new ChatController( this );
        }

        private void InitializeEvents( ) {
            buttonLeave.Click += ButtonLeave_Click;
            buttonSend.Click += ButtonSend_Click;
        }

        #region Event for button Leave
        public delegate void EventHandlerLeave( object sender, EventArgs e );
        public event EventHandlerLeave EventLeave;
        private void ButtonLeave_Click( object sender, RoutedEventArgs e ) {
            EventLeave?.Invoke( this , EventArgs.Empty );
        }
        #endregion

        #region Event for button Send
        public delegate void EventHandlerSend( object sender, EventArgs e );
        public event EventHandlerSend EventSend;
        private void ButtonSend_Click( object sender, RoutedEventArgs e ) {
            EventSend?.Invoke( this, EventArgs.Empty );
        }
        #endregion

    }
}
