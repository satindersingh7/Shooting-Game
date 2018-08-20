using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Media;

namespace Shootinggametest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\user\Downloads\shot.wav");
            player.Play();
            Assert.IsTrue(player != null);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int Score = 0;
            Assert.IsTrue(Score == 0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int total_shots = 0;
            Assert.IsTrue(total_shots == 0);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int miss_shots = 0;
            Assert.IsTrue(miss_shots == 0);
        }
    }
}
