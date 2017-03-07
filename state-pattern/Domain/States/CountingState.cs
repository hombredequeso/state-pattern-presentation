namespace StatePattern.Domain.States
{
    public class CountingState : ICounterState
    {
        // State of... 
        private readonly Counter _counter;

        // State data:
        private readonly int _maxCount;
        private int _count;

        public int GetCount()
        {
            return _count;
        }

        // TODO : from here down...

        public CountingState(Counter c, int maxCount)
        {
        }

        public void Inc()
        {
        }

        public void Initialize()
        {
        }

        public void Reset()
        {
        }

        public void Clear()
        {
        }

        public void SetMaxCount(int maxCount)
        {
        }
    }
}