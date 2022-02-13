public class RotateLeftCommand : RoverCommandBase
{


    public RotateLeftCommand(Rover rover) : base(rover) { }

    public override ActionResultSet Execute()
    {
        return _rover.RotateLeft();
    }

}