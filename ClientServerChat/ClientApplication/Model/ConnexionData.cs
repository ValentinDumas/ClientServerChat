using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Model
{
    public class ConnexionData
    {
        private string _pseudo = String.Empty;
        public string Pseudo { get { return _pseudo; } set { _pseudo = value; } }

        private string _serverIp = String.Empty;
        public string ServerIp { get { return _serverIp; } set { _serverIp = value; } }
    }
}
