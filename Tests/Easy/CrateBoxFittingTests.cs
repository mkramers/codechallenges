using System.Collections;
using Challenges.Easy;
using NUnit.Framework;

namespace Tests.Easy
{
    [TestFixture]
    public class CrateBoxFittingTests
    {
        private static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(25, 18, 6, 5).Returns(12);
                yield return new TestCaseData(10, 10, 1, 1).Returns(100);
                yield return new TestCaseData(12, 34, 5, 6).Returns(10);
                yield return new TestCaseData(12345, 678910, 1112, 1314).Returns(5676);
                yield return new TestCaseData(5, 100, 6, 1).Returns(0);
            }
        }

        [Test]
        [TestCaseSource(nameof(TestCases))]
        public int OutputCorrect(int _crateX, int _crateY, int _boxX, int _boxY)
        {
            return CrateBoxFitting.HowManyBoxesFit(_crateX, _crateY, _boxX, _boxY);
        }
    }
}