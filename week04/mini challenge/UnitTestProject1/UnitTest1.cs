using Microsoft.VisualStudio.TestTools.UnitTesting;
using personclasslibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void studenttest()
        {
            string fName="abc";
            string sName = "def";

            var test = new Person.Student(fName, sName, bYear, ID);
        }
    }
}
