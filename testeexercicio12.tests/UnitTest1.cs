using NUnit.Framework;
using exercicio12L1;

namespace testeexercicio12.tests
{
    [TestFixture]
    public class Tests
    {
    
        [Test]
        public void Test1()
        {
            RetornaSomaPares p = new RetornaSomaPares();

            var result = p.SomaPares(1,2,3,4,8);

            Assert.That(14, Is.EqualTo(result));

        }

         [Test]
        public void Test2()
        {
            RetornaSomaPares p = new RetornaSomaPares();
            
            var result = p.SomaPares(0,2);

            Assert.That(2, Is.EqualTo(result));

        }

         [Test]
        public void Test3()
        {
            RetornaSomaPares p = new RetornaSomaPares();
            
            var result = p.SomaPares(2,4);

            Assert.That(6, Is.EqualTo(result));

        }

       
    }
}