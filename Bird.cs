using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRDSFLYINGAROUNDAPP
{
    public abstract class Bird
    {
        public abstract int Longitude { get; set; }
        public abstract int Latitude { get; set; }

        public abstract void SetLocation(int longitude, int latitude);
    }
}
