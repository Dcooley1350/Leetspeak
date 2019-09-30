using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.L1337speak;

namespace L1337Speak.Tests
{
    [TestClass]
    public class L1337speakTests
    {
        [TestMethod]
        public void StringToArray_ChangeAStringToAnArray_True()
        {
            L1337speak newL1337speak = new L1337speak ("This is Elite.");
            char[] array = newL1337speak.StringToArray();
            char[] correctArray = {'T','h','i','s',' ','i','s',' ','E','l','i','t','e','.'};
            CollectionAssert.AreEqual(correctArray, array);
        }
        [TestMethod]
        public void EtoThree_ChangesEtoNumberThree_true()
        {
            L1337speak newL1337speak = new L1337speak ("This is Elite.");
            char[] array = newL1337speak.StringToArray();
            L1337speak.EToThree(array);
            string newString = string.Join("", array);
            string correctString = "This is 3lit3.";
            Assert.AreEqual(correctString, newString);
        }
    }
}