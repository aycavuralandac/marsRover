public class RoverController
{
    public Queue<RoverCommandBase> Commands;

    public RoverController()
    {
        Commands = new Queue<RoverCommandBase>();
    }

    public void ExecuteCommands()
    {
        while (Commands.Count > 0)
        {
            RoverCommandBase command = Commands.Dequeue();
            ActionResultSet movementResult = command.Execute();
            if (movementResult.Code == 1)
            {
                Console.WriteLine(movementResult.Description);
                break;
            }
        }
    }

}