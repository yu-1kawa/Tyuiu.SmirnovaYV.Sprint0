using Tyuiu.SmirnovaYV.Sprint0.Task2.V0.lib;
namespace Tyuiu.SmirnovaYV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Юлия";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Юлия", res);
        }
    }
}
