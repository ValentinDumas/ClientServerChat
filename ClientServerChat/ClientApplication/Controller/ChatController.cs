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
    class ChatController
    {
        private ChatControl _chatControl;

        public ChatController( ChatControl chatControl ) {
            _chatControl = chatControl;
            InitializeEvents( );
        }

        public void InitializeEvents( ) { }

    }
}
