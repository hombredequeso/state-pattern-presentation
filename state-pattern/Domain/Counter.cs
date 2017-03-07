using StatePattern.Domain.States;

namespace StatePattern.Domain
{
    public class Counter
    {
        public ICounterState State;

        public Counter(int maxCount)
        {
            State = new UninitializedState(this, maxCount);
        }

        public int GetCount()
        {
            return State.GetCount();
        }

        public void Inc()
        {
            State.Inc();
        }

        public void Initialize()
        {
            State.Initialize();
        }

        public void Reset()
        {
            State.Reset();
        }

        public void Clear()
        {
            State.Clear();
        }

        public void SetMaxCount(int maxCount)
        {
            State.SetMaxCount(maxCount);
        }
    }
}
