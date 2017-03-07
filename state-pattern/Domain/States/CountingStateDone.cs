namespace StatePattern.Domain.States
{
    //public class CountingState: ICounterState
    //{
    //    // State of... 
    //    private readonly Counter _counter;

    //    // State data:
    //    private readonly int _maxCount;
    //    private int _count;

    //    public CountingState(Counter c, int maxCount)
    //    {
    //        _counter = c;
    //        _maxCount = maxCount;
    //        _count = 0;
    //    }

    //    public int GetCount()
    //    {
    //        return _count;
    //    }

    //    public void Inc()
    //    {
    //        ++_count;
    //        if (_count == _maxCount)
    //            _counter.State = new FinishedState(_counter, _maxCount);
    //    }

    //    public void Initialize()
    //    {
    //    }

    //    public void Reset()
    //    {
    //        _counter.State = new UninitializedState(_counter, _maxCount);
    //    }

    //    public void Clear()
    //    {
    //        _count = 0;
    //    }

    //    public void SetMaxCount(int maxCount)
    //    {
    //    }
    //}
}