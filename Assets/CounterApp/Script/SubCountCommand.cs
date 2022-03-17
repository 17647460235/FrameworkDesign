using FrameworkDesign;

namespace CounterApp
{
    public struct SubCountCommand: ICommand

    {
        public void Execute()
        {
            CountModel.Instance.Count.Value--;
        }
    }
}