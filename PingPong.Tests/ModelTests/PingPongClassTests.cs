using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
    [TestClass]
    public class PingPongTest
    {
        [TestMethod]
        public void ReplaceWithPing_IfNumberIsDivisibleByThree_True()
        {
            PingPongClass testPingPongClass = new PingPongClass();
            Assert.AreEqual("ping", testPingPongClass.Number(3));
        }
        [TestMethod]
        public void ReplaceWithPong_IfNumberIsDivisibleByFive_True()
        {
            PingPongClass testPingPongClass = new PingPongClass();
            Assert.AreEqual("pong", testPingPongClass.Number(5));
        }
        [TestMethod]
        public void ReplaceWithPingPong_IfNumberIsDivisibleByThreeAndFive_True()
        {
            PingPongClass testPingPongClass = new PingPongClass();
            Assert.AreEqual("ping-pong", testPingPongClass.Number(15));
        }

    }
}