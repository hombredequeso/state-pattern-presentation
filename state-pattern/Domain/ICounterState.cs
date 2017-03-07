namespace StatePattern.Domain
{
    public interface ICounterState
    {
        int GetCount();
        void Inc();
        void Initialize();
        void Reset();
        void Clear();
        void SetMaxCount(int maxCount);
    }
}