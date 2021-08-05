using MyTestProject.Services;
using System;
using Xunit;

namespace MyTestProject
{
    public class UnitTest1
    {
        private readonly IMyService _service;

        public UnitTest1(IMyService service)
        {
            _service = service;
        }

        [Fact]
        public void Test1()
        {
            var guid = new Guid();
            var expected = guid.ToString();

            var actual = _service.Get(guid);

            Assert.Equal(expected, actual);
        }
    }
}
