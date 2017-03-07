namespace StatePattern.Domain.States
{
    public class UninitializedState : ICounterState
    {
        // State of... 
        private readonly Counter _counter;

        // State data:
        private int _maxCount;

        public UninitializedState(Counter c, int maxCount)
        {
            _counter = c;
            _maxCount = maxCount;
        }

        public int GetCount()
        {
            return 0;
        }

        public void Inc()
        {
        }

        public void Initialize()
        {
            _counter.State = new CountingState(_counter, _maxCount);
        }

        public void Reset()
        {
        }

        public void Clear()
        {
        }

        public void SetMaxCount(int maxCount)
        {
            _maxCount = maxCount;
        }
    }
}