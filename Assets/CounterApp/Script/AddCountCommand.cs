using FrameworkDesign;

namespace CounterApp
{
    public struct AddCountCommand : ICommand
    {
        public void Execute()
        {
            CountModel.Count.Value++;
        }
    }
}