using ClientApplication.Model;
using ClientApplication.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Controller
{
    class ChatController : Controller
    {
        private ChatControl _chatControl;

        public ChatController( ChatControl chatControl ) {
            this._chatControl = chatControl;
            InitializeEvents( );
        }

        public void InitializeEvents( ) {
            _chatControl.EventLeave += _chatControl_EventLeave;
            _chatControl.EventSend  += _chatControl_EventSend;
        }

        private void _chatControl_EventLeave( object sender, EventArgs e ) {
            
        }

        // @TODO : Implement all model classes in 
        private void _chatControl_EventSend( object sender, EventArgs e ) {
            Model.ChatData.Message = _chatControl.textBoxMessage.Text.ToString( );
            if (_chatControl.textBoxMessage.Text != "" ) {
                
            }
        }
    }
}
