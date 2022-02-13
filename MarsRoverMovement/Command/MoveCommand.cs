public class MoveCommand : RoverCommandBase
{


    public MoveCommand(Rover rover) : base(rover) { }

    public override ActionResultSet Execute()
    {
        return _rover.Move();
    }

}