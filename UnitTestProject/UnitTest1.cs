using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using THSplit;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
      
        [TestMethod]
        public void TestCtor()
        {
            Spliter spliter = new Spliter();
        }

        [TestMethod]
        public void TestSplit1()
        {
            Spliter spliter = new Spliter();
            string test = "นายจะไปไหนหรอ";
            var output = spliter.SegmentByDictionary(test);
 
            var asset = new List<string>
            {
                "นาย",
                "จะ",
                "ไป",
                "ไหน",
                "หรอ"
            };
            foreach (var variable in output)
            {
                Console.WriteLine(variable);
            }
            Assert.AreEqual(asset.Count, output.Count);
            Assert.AreEqual(asset[0], output[0]);
            Assert.AreEqual(asset[1], output[1]);
            Assert.AreEqual(asset[2], output[2]);
            Assert.AreEqual(asset[3], output[3]);
            Assert.AreEqual(asset[4], output[4]);
        }

        [TestMethod]
        public void TestSplit2()
        {
            Spliter spliter = new Spliter();
            string test = "ไอ้นี่ถ้าจะบ้า";
            var output = spliter.SegmentByDictionary(test);
           
            var asset = new List<string>
            {
                "ไอ้",
                "นี่",
                "ถ้า",
                "จะ",
                "บ้า"
            };

            Assert.AreEqual(asset.Count, output.Count);
            Assert.AreEqual(asset[0], output[0]);
            Assert.AreEqual(asset[1], output[1]);
            Assert.AreEqual(asset[2], output[2]);
            Assert.AreEqual(asset[3], output[3]);
            Assert.AreEqual(asset[4], output[4]);
        }
    }
}
