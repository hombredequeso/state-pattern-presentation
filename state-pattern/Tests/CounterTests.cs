using FluentAssertions;
using NUnit.Framework;
using StatePattern.Domain;

namespace StatePattern.Tests
{
    [TestFixture]
    public class CounterTests
    {
        [Test]
        public void Counter_Does_Not_Count_If_Uninitialized()
        {
            var counter = new Counter(1);
            counter.Inc();

            counter.GetCount()
                .Should().Be(0);
        }

        [Test]
        public void Counter_Increments_When_Initialized()
        {
            var counter = new Counter(10);
            counter.Initialize();
            counter.Inc();

            counter.GetCount()
                .Should().Be(1);
        }

        [Test]
        public void Counter_Can_Count()
        {
            var increments = 4;
            var counter = new Counter(increments);
            counter.Initialize();

            for (var x=0;x<increments;x++)
                counter.Inc();

            counter.GetCount()
                .Should().Be(4);
        }

        [Test]
        public void Counter_Does_Not_Count_Past_MaxCount()
        {
            var max = 4;
            var increments = max + 3;
            var counter = new Counter(4);
            counter.Initialize();
            for (var x=0;x<increments;x++)
                counter.Inc();

            counter.GetCount()
                .Should().Be(4);
        }

        [Test]
        public void Counter_Can_Reset_While_Counting()
        {
            var counter = new Counter(2);
            counter.Initialize();
            counter.Inc();
            counter.Reset();

            counter.GetCount()
                .Should().Be(0);
        }
        
        [Test]
        public void Counter_Can_Reset_When_Finished_Counting()
        {
            var counter = new Counter(1);
            counter.Initialize();
            counter.Inc();
            counter.Reset();

            counter.GetCount()
                .Should().Be(0);
        }

        [Test]
        public void Counter_Can_Be_Cleared_While_Counting()
        {
            var counter = new Counter(2);
            counter.Initialize();
            counter.Inc();
            counter.Clear();

            counter.GetCount()
                .Should().Be(0);
        }


        [Test]
        public void Counter_Sequence_Test_A()
        {
            var maxCount = 3;
            var counter = new Counter(maxCount);

            counter.Inc();  // does nothing

            counter.Initialize();
            counter.Inc();
            counter.Clear();    // back to 0
            for (var x=0;x<maxCount + 4;x++)
                counter.Inc();

            counter.GetCount()
                .Should().Be(maxCount);
        }
    }
}