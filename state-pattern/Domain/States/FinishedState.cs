namespace StatePattern.Domain.States
{
    public class FinishedState : ICounterState
    {
        // State of... 
        private readonly Counter _counter;

        // State data
        private int _maxCount;
        private readonly int _count;

        public FinishedState(Counter c, int maxCount)
        {
            _counter = c;
            _maxCount = maxCount;
            _count = maxCount;
        }

        public int GetCount()
        {
            return _count;
        }

        public void Inc()
        {
        }

        public void Initialize()
        {
        }

        public void Reset()
        {
            _counter.State = new UninitializedState(_counter, _maxCount);
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