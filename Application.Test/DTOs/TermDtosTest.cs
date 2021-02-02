using ApplicationCore.DTOs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Test
{
    [TestClass]
    public class TermDtosTest
    {
        //init Object to unit test.
        Term termDtos = new Term();

        [TestMethod]
        public void IsValid_TermDoesNotExist_ReturnFalse()
        {
            Assert.AreEqual(false, termDtos.IsValid(-1));
        }

        [TestMethod]
        public void IsValid_TermExist_ReturnTrue()
        {
            Assert.AreEqual(true, termDtos.IsValid(0));
        }
    }
}
