using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Model
{
    class ConnexionData
    {
        private string _pseudo = "ee";
        public string Pseudo { get { return _pseudo; } set { _pseudo = value; } }

        private string _serverIp = "";
        public string ServerIp { get { return _serverIp; } set { _serverIp = value; } }
    }
}
