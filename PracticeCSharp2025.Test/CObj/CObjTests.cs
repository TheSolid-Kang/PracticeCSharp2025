using Moq;
using PracticeCSharp2025.CObj;
using System;
using Xunit;

namespace PracticeCSharp2025.Test.CObj
{
    public class CObjTests
    {
        private MockRepository mockRepository;



        public CObjTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private PracticeCSharp2025.CObj.CObj CreateCObj()
        {
            return new PracticeCSharp2025.CObj.CObj();
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
