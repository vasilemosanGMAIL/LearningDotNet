namespace HelloWorld
{
    public class Stack
    {

        private List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null) throw new InvalidOperationException("object can't be null");
            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0) throw new InvalidOperationException("stack is empty");

            var poppedItem = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count - 1);
            return poppedItem;
        }

        public void Clear()
        {
            if (_stack.Count == 0) Console.WriteLine("Stack is already empty");
            else
            {
                _stack.Clear();
                Console.WriteLine("stack is empty");
            }
        }
    }
}
