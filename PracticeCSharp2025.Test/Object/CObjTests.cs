using Moq;
using PracticeCSharp2025.Object;
using System;
using Xunit;

namespace PracticeCSharp2025.Test.Object
{
    public class CObjTests
    {
        public CObjTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }


        private MockRepository mockRepository;


        private CObj CreateCObj()
        {
            return new CObj();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var cObj = this.CreateCObj();

            // Act


            // Assert
            Assert.True(true);
            this.mockRepository.VerifyAll();
        }
    }
}
