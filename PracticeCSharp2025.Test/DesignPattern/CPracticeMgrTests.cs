using Moq;
using PracticeCSharp2025.DesignPattern;
using System;
using Xunit;

namespace PracticeCSharp2025.Test.DesignPattern
{
    public class CPracticeMgrTests
    {
        private MockRepository mockRepository;


        public CPracticeMgrTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private CPracticeMgr CreateCPracticeMgr()
        {
            return CPracticeMgr.GetInstance;
        }

        [Fact]
        public void SetPractice_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var cPracticeMgr = this.CreateCPracticeMgr();
            CPracticeMgr.PRACTICE _selectdPractice = default(global::PracticeCSharp2025.DesignPattern.CPracticeMgr.PRACTICE);

            // Act
            cPracticeMgr.SetPractice(_selectdPractice);

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void GetPractice_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var cPracticeMgr = this.CreateCPracticeMgr();

            // Act
            var result = cPracticeMgr.GetPractice();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }
    }
}
