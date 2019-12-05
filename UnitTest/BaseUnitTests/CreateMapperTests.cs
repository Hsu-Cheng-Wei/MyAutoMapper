using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMapper;

namespace UnitTest.BaseUnitTests
{
    public class Source
    { }

    public class Destination { }

    [TestClass]
    public class CreateMapperTests
    {
        [TestMethod]
        public void MappingConfigureTests()
        {
            var configure = new MapperConfiguration(cfg => cfg.CreateMapper<Source, Destination>());

            Assert.IsNotNull(configure.FindTypeMapFor<Source, Destination>());
        }
    }
}
