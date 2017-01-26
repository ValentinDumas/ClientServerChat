using ClientApplication.Model;
using ClientApplication.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClientApplication.Controller
{
    class ChatController : Controller
    {
        private ChatControl _chatControl;
        private ConnexionControl _connexionControl;

        public ChatController( ChatControl chatControl ){
            _chatControl = chatControl;
            InitializeEvents( );
        }

        public void InitializeEvents( ) {
            _chatControl.EventSend  += ChatControl_EventSend;
        }

        private void ChatControl_EventSend( object sender, EventArgs e ) {
            Model.ChatData.Message = _chatControl.textBoxMessage.Text.ToString( );
            if ( Model.ChatData.Message != "" ) {
                _chatControl.textBlockChat.Text += Environment.NewLine
                                                + Model.ChatData.Message;
            }
            _chatControl.textBoxMessage.Clear( );
        }
    }
}
