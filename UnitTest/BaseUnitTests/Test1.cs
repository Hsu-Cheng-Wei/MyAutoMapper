using Xunit;

namespace UnitTest.BaseUnitTests
{
    public class Test1 : Base
    {
        public Test1() { }

        [Fact]
        public void Foo()
        {
            Assert.True(true);
        }
    }
}
