using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Model
{
    public class ChatData
    {
        private string _message = "";
        public string Message { get { return _message; } set { _message = value; } }
    }
}
