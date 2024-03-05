namespace HelloWorld
{
    public class Stopwatch
    {
        /* My implementation
         * *
         * */
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;

        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is already running.");

            _startTime = DateTime.Now;
            Console.WriteLine($"Start time is {_startTime}");
            _running = true;
        }

        public void Stop()
        {

            if (!_running)
                throw new InvalidOperationException("Stopwatch is not running.");

            _endTime = DateTime.Now;
            var duration = _endTime - _startTime;
            Console.WriteLine($"End time is {_endTime}");
            Console.WriteLine($"Duration is {duration.Seconds} seconds");
            _running = false;
        }


    }
}
