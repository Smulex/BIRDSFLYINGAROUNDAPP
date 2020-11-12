using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRDSFLYINGAROUNDAPP
{
    interface IFly
    {
        int Altitude { get; set; }

        void SetAltitude(int altitude);

    }
}
