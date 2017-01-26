using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.Model
{
    public interface IModel
    {
        ChatData ChatData {
            get;
            set;
        }

        ConnexionData ConnexionData {
            get;
            set;
        }

        ClientSession ClientSession {
            get;
            set;
        }
    }
}
