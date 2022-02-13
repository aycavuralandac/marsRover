public class RoverMovement
{
    public void Run(List<Rover> roverList)
    {
        int index = 1;
        foreach (var rover in roverList)
        {
            var controller = new RoverController();
            var directions = rover.DirectionSet;
            foreach (var movement in directions)
            {
                switch (movement)
                {
                    case Movement.Left:
                        var rotateLeft = new RotateLeftCommand(rover);
                        controller.Commands.Enqueue(rotateLeft);
                        break;
                    case Movement.Right:
                        var rotateRight = new RotateRightCommand(rover);
                        controller.Commands.Enqueue(rotateRight);
                        break;
                    case Movement.Move:
                        var move = new MoveCommand(rover);
                        controller.Commands.Enqueue(move);
                        break;
                    default: break;
                }
            }
            controller.ExecuteCommands();
            Console.WriteLine("{0}.rovers last coordinate: {1} ", index, rover.GetPosition());
            index += 1;
        }
    }
}