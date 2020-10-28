using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SignTest()
        {
            int a = 6;
            int res = 1;
            int actual = ConsoleApp6.Program.Sign( a);
            Assert.AreEqual(res, actual);
        }
        [Test]
        public void RootsCountTest()
        {
            int a = 1;
            int b = 2;
            int c = -6;
            int res = 2;
            int actual = ConsoleApp6.Program.RootsCount(a,b,c);
            Assert.AreEqual(res, actual);
        }

        [Test]
        public void CircleSTest()
        {
            int r = 1;
            double res = 3.14;
            double actual = ConsoleApp6.Program.CircleS(r);
            Assert.AreEqual(res, actual);
        }
        [Test]
        public void RingSTest()
        {
            int R1 = 3, R2 = 1;
            double res = 6.28;
            double actual = ConsoleApp6.Program.RingS(R1,R2);
            Assert.AreEqual(res, actual);
        }
        [Test]
        public void TrianglePTest()
        {
            int a = 6, h = 4;
            double res = 5;
            double actual = ConsoleApp6.Program.TriangleP(a, h);
            Assert.AreEqual(res, actual);
        }
    }
}