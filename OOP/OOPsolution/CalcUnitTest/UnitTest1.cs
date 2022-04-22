using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;

namespace CalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod("���ϱ� �׽�Ʈ")]
        public void TestMethod1()
        {
            Myclass myClass = new Myclass();
            int a = 3, b = 5;
            var result = myClass.Plus(a, b);

            Assert.AreEqual(8, result); //�׽�Ʈ ���

        }
        [TestMethod()]
        public void DivideTest()
        {
            Myclass myClass = new Myclass();
            int a = 10, b = 3;
            var result = myClass.Plus(a, b);
            var expected = 3;
            Assert.AreEqual(expected, result);


            Assert.AreEqual(8, result); //�׽�Ʈ ���

        }

    }
}
