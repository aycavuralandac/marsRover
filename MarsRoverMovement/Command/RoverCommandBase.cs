public abstract class RoverCommandBase
{
    protected Rover _rover;

    public RoverCommandBase(Rover rover)
    {
        _rover = rover;
    }

    public abstract ActionResultSet Execute();

}