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
        [TestMethod]
        public void OtoZero_ChangesOtoNumberZero_true()
        {
            L1337speak newL1337speak = new L1337speak ("This is not Elite.");
            char[] array = newL1337speak.StringToArray();
            L1337speak.OToZero(array);
            string newString = string.Join("", array);
            string correctString = "This is n0t Elite.";
            Assert.AreEqual(correctString, newString);
        }
        [TestMethod]
        public void ItoOne_ChangesItoNumberOne_true()
        {
            L1337speak newL1337speak = new L1337speak ("I am Elite.");
            char[] array = newL1337speak.StringToArray();
            L1337speak.IToOne(array);
            string newString = string.Join("", array);
            string correctString = "1 am Elite.";
            Assert.AreEqual(correctString, newString);
        }
        [TestMethod]
        public void TtoSeven_ChangesTtoSeven_true()
        {
            L1337speak newL1337speak = new L1337speak ("I am Elite.");
            char[] array = newL1337speak.StringToArray();
            L1337speak.TtoSeven(array);
            string newString = string.Join("", array);
            string correctString = "I am Eli7e.";
            Assert.AreEqual(correctString, newString);
        }
        [TestMethod]
        public void StoZ_ChangesStoZ_true()
        {
            L1337speak newL1337speak = new L1337speak ("I am Elites.");
            char[] array = newL1337speak.StringToArray();
            L1337speak.StoZ(array);
            string newString = string.Join("", array);
            string correctString = "I am Elitez.";
            Assert.AreEqual(correctString, newString);
        }
    }
}