using MarsRover.data.model;
using MarsRover.HelperMethods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<RoverItem> roverList = new List<RoverItem>();
            Plateau plateu;


            Console.WriteLine("Enter Platue's Upper Right Coordinates (X Y):");
            List<string> MaxCoordinates = Console.ReadLine().TrimEnd().Split(' ').ToList();
            plateu = Helpers.GetPlateau(MaxCoordinates);

            int roverCount = 1;
            while (true)
            {
                RoverItem newRover = new RoverItem();
                if (roverCount > 0)
                {
                    Console.WriteLine("Press \"ENTER\" Button To Calculate Or ");
                }
                Console.WriteLine("Enter ({0})Rover's Initial Coordinates And Direction (X Y D) : ", roverCount);
                List<string> positionValues = Console.ReadLine().TrimEnd().Split(' ').ToList();
                newRover.initialPosition = Helpers.GetRoverPosition(positionValues);

                if (newRover.initialPosition == null)
                {
                    break;
                }
                Console.WriteLine("Enter ({0})Rover's Commands (DDDDD): ", roverCount);
                newRover.commands = Console.ReadLine();
                roverList.Add(newRover);
                roverCount++;
            }

            foreach(RoverItem r in roverList)
            {
                Rover rover = new Rover(r.initialPosition, plateu);
                rover.ExecuteCommands(r.commands);
                Console.WriteLine(rover.GetCurrentPosition());
            }
        }
    }

    class RoverItem
    {
        public RoverPosition initialPosition;
        public string commands;
    }
}
