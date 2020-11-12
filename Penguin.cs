using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRDSFLYINGAROUNDAPP
{
    public class Penguin : Bird
    {
        public override int Longitude { get; set; }
        public override int Latitude { get; set; }

        //Sætter location når den bliver instantieret
        public Penguin(int longitude, int latitude)
        {
            SetLocation(longitude, latitude);
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
            return $"(Penguin) Jeg er på ({Longitude}, {Latitude})";
        }
    }
}
