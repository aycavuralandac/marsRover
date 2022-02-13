// Program.cs



namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the plateou size (X Y) : ");
            string? line = "";
            List<Rover> roverList = new List<Rover>();
            line = Console.ReadLine();
            Coordinate plateu = null;
            if (!string.IsNullOrEmpty(line))
            {
                string[] plateouInfo = line.Split(" ");
                if (plateouInfo.Length == 2)
                {
                    plateu = new Coordinate(Int32.Parse(plateouInfo[0]), Int32.Parse(plateouInfo[1]));
                }
                else
                {
                    Console.WriteLine("You've entered wrong formatted size. Exiting...");
                    Environment.Exit(1);
                }
            }

            string? answer = "Y";
            string? leaveAnswer = "N";
            while (plateu != null && leaveAnswer != "Y" && answer != null && answer.Equals("Y"))
            {
                Console.WriteLine("Please enter rover's position (X Y for coordinates and D for direction) with spaces (X Y D) : ");
                line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line))
                {
                    // input checks
                    string[] roverInfo = line.Split(" ");
                    if (roverInfo.Length == 3)
                    {
                        var coordinate = new Coordinate(Int32.Parse(roverInfo[0]), Int32.Parse(roverInfo[1]));
                        Console.WriteLine("Please enter rover's instruction set (L-Left, R-Rigth and M for Move) with no spaces (such as LMLMLMLMM) : ");
                        var directionSet = Console.ReadLine();
                        if (!string.IsNullOrEmpty(directionSet))
                        {
                            var rover = new Rover(coordinate, roverInfo[2], plateu, directionSet);
                            roverList.Add(rover);
                        }
                        Console.WriteLine("Are you going to enter a new rover information? (Y/N) ");
                        answer = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You've entered wrong formatted data. Dou you want to leave? (Y/N) ");
                        leaveAnswer = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("You've entered wrong formatted data. Dou you want to leave? (Y/N) ");
                    leaveAnswer = Console.ReadLine();
                }
            }

            if (roverList.Count() > 0)
            {
                var RoverMovement = new RoverMovement();
                RoverMovement.Run(roverList);
            }

        }
    }
}