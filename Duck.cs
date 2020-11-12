using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRDSFLYINGAROUNDAPP
{
    public class Duck : Bird, IFly
    {
        public int Altitude { get; set; }
        public override int Longitude { get; set; }
        public override int Latitude { get; set; }

        //Sætter location og altitude når den bliver instantieret
        public Duck(int longitude, int latitude, int altitude)
        {
            SetLocation(longitude, latitude);
            SetAltitude(altitude);
        }

        //Sætter altitude
        public void SetAltitude(int altitude)
        {
            Altitude = altitude;
        }

        //Sætter location
        public override void SetLocation(int longitude, int latitude)
        {
            Longitude = longitude;
            Latitude = latitude;
        }

        //Overskriver ToString metoden
        public override string ToString()
        {
            return $"(Duck) Jeg er på ({Longitude}, {Latitude}) og er {Altitude}m oppe";
        }
    }
}
