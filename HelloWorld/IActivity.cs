namespace HelloWorld
{
    internal interface IActivity
    {
        void Execute();
    }

    internal interface IWorkflow
    {
        void Add(IActivity task);
        void Remove(IActivity task);
        IEnumerable<IActivity> GetTasks();
    }

}
