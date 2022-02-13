public class Rover
{
    private Coordinate Coordinate { get; set; }
    public String RoverDirection { get; set; }
    public Coordinate PlateuSize { get; set; }
    public string DirectionSet { get; set; }
    public Rover(Coordinate coordinate, string direction, Coordinate plateuSize, string directionSet)
    {
        Coordinate = coordinate;
        RoverDirection = direction;
        PlateuSize = plateuSize;
        DirectionSet = directionSet;
    }
    public string GetPosition()
    {
        return this.Coordinate.X + " " + this.Coordinate.Y + " " + this.RoverDirection;
    }
    public ActionResultSet Move()
    {
        ActionResultSet result = new ActionResultSet(Messages.SUCCESS_CODE, Messages.SUCCESS);
        switch (RoverDirection)
        {
            case Direction.East:
                if (PlateuSize.X >= Coordinate.X + 1)
                {
                    Coordinate.X += 1;
                }
                else
                {
                    return new ActionResultSet(Messages.ERROR_CODE, Messages.OUT_OF_PLATEU);
                }
                break;
            case Direction.North:
                if (PlateuSize.Y >= Coordinate.Y + 1)
                {
                    Coordinate.Y += 1;
                }
                else
                {
                    return new ActionResultSet(Messages.ERROR_CODE, Messages.OUT_OF_PLATEU);
                }
                break;
            case Direction.West:
                if (Coordinate.X - 1 >= 0)
                {
                    Coordinate.X -= 1;
                }
                else
                {
                    return new ActionResultSet(Messages.ERROR_CODE, Messages.OUT_OF_PLATEU);
                }
                break;
            case Direction.South:
                if (Coordinate.Y - 1 >= 0)
                {
                    Coordinate.Y -= 1;
                }
                else
                {
                    return new ActionResultSet(Messages.ERROR_CODE, Messages.OUT_OF_PLATEU);
                }
                break;
            default: break;
        }
        return result;
    }

    public ActionResultSet RotateLeft()
    {
        ActionResultSet result = new ActionResultSet(Messages.SUCCESS_CODE, Messages.SUCCESS);
        switch (RoverDirection)
        {
            case Direction.East:
                RoverDirection = Direction.North;
                break;
            case Direction.North:
                RoverDirection = Direction.West;
                break;
            case Direction.West:
                RoverDirection = Direction.South;
                break;
            case Direction.South:
                RoverDirection = Direction.East;
                break;
            default: break;
        }
        return result;
    }

    public ActionResultSet RotateRight()
    {
        ActionResultSet result = new ActionResultSet(Messages.SUCCESS_CODE, Messages.SUCCESS);
        switch (RoverDirection)
        {
            case Direction.East:
                RoverDirection = Direction.South;
                break;
            case Direction.North:
                RoverDirection = Direction.East;
                break;
            case Direction.West:
                RoverDirection = Direction.North;
                break;
            case Direction.South:
                RoverDirection = Direction.West;
                break;
            default: break;
        }
        return result;
    }

}