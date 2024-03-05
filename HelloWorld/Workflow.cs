namespace HelloWorld
{
    internal class Workflow : IWorkflow
    {
        private readonly List<IActivity> _tasks;

        public Workflow()
        {
            _tasks = new List<IActivity>();
        }

        public void Add(IActivity task)
        {
            _tasks.Add(task);
        }

        public void Remove(IActivity task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<IActivity> GetTasks()
        {
            return _tasks;
        }
    }
}
