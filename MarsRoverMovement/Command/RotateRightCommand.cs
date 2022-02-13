public class RotateRightCommand : RoverCommandBase
{

    public RotateRightCommand(Rover rover) : base(rover) { }

    public override ActionResultSet Execute()
    {
        return _rover.RotateRight();
    }

}
