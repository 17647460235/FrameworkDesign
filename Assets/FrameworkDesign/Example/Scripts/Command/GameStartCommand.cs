namespace FrameworkDesign.Example
{
    public class GameStartCommand : ICommand
    {
        public void Execute()
        {
            GameStartEvent.Trigger();
        }
    }
}