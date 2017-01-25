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

        }


    }
}
