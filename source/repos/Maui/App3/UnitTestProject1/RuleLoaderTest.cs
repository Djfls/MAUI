using App4.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using App4.Logic.L5;
using Rule = App4.Logic.L5.Rule;
using RuleLoader = App4.Logic.L5.RuleLoader;

namespace App4
{
    [TestClass]
    public class RuleLoaderTest
    {
        [TestMethod]
        public async Task LoadAndNextTest_LangtonsLoops()
        {
            Rule rule = await RuleLoader.LoadAsync("Langtons-Loops.table.txt");

            Assert.AreEqual(5, rule.Next(7, 0, 2, 5, 2));
            Assert.AreEqual(5, rule.Next(7, 2, 0, 2, 5));
            Assert.AreEqual(5, rule.Next(7, 5, 2, 0, 2));
            Assert.AreEqual(5, rule.Next(7, 2, 5, 2, 0));
        }

    }
}
