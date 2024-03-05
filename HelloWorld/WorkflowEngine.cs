namespace HelloWorld
{
    internal class WorkflowEngine
    {
        public void Run(IWorkflow workflow) { 
            foreach (IActivity I in workflow.GetTasks())
            {
                I.Execute();
            }
        }


    }
}
