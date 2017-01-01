using Explorer;
using NUnit.Framework;
using System.Windows.Forms;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestUTRuns()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void Test_tool_controler()
        {
            try
            {
                ToolControler tc = new ToolControler();
                Assert.IsNotNull(tc.ListDrivers);
                Assert.IsNotNull(tc.CurrentFileList);
                Assert.IsNotNull(tc.CurrentFolderList);
                Assert.IsNotNull(tc.CurrentPath);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_explorer_display()
        {
            try
            {
                RichExplorer re = new RichExplorer();
                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_displays_deom()
        {
            try
            {
                Calendar c = new Calendar();
                Edit e = new Edit();
                GUI g = new GUI();
                Monitor m = new Monitor();

                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
    }
}
