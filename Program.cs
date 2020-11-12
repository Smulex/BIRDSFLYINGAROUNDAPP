using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIRDSFLYINGAROUNDAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird penguin = new Penguin(15, 15);
            Duck duck = new Duck(30, 30, 1);

            while (true)
            {
                Console.WriteLine(penguin.ToString());
                Console.WriteLine(duck.ToString());

                Console.WriteLine("\n\t 1 - Move penguin");
                Console.WriteLine("\t 2 - Move duck");


                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        Console.Write("What is the longitude: ");
                        int lon = Convert.ToInt32(Console.ReadLine());
                        Console.Write("What is the latitude: ");
                        int lat = Convert.ToInt32(Console.ReadLine());
                        penguin.SetLocation(lon, lat);
                        break;
                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("\t 1 - Set Location");
                        Console.WriteLine("\t 2 - Set altitude");
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.D1:
                                Console.Write("What is the longitude: ");
                                lon = Convert.ToInt32(Console.ReadLine());
                                Console.Write("What is the latitude: ");
                                lat = Convert.ToInt32(Console.ReadLine());
                                duck.SetLocation(lon, lat);
                                break;
                            case ConsoleKey.D2:
                                Console.Write("What is the altitude: ");
                                int alt = Convert.ToInt32(Console.ReadLine());
                                duck.SetAltitude(alt);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                Console.Clear();
            }
        }
    }
}
