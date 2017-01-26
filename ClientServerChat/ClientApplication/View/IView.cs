using ClientApplication.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication.View
{
    public interface IView
    {
        ClientWindow ClientWindow { get; set; }

        ConnexionControl ConnexionControl { get; set; }

        ChatControl ChatControl { get; set; }
    }
}
