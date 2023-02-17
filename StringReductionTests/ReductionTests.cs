using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringReduction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReduction.Tests
{
    [TestClass()]
    public class ReductionTests
    {
        [TestMethod()]
        public void GetReductionStringTest()
        {
            Assert.AreEqual("A3B4C3AB", Reduction.GetReductionString("AAABBBBCCCAB"));
            Assert.AreEqual("AB4C3AB2", Reduction.GetReductionString("ABBBBCCCABB"));
            Assert.AreEqual("A4B5C3ABA", Reduction.GetReductionString("AAAABBBBBCCCABA"));
            Assert.AreEqual("ASDFGHJK", Reduction.GetReductionString("ASDFGHJK"));
            Assert.AreEqual("ASDFGHJK2", Reduction.GetReductionString("ASDFGHJKK"));

            Assert.AreEqual("A", Reduction.GetReductionString("A"));
            Assert.AreEqual("A2", Reduction.GetReductionString("AA"));
            Assert.AreEqual("", Reduction.GetReductionString(""));
        }

        [TestMethod()]
        public void GetReductionStringTestExceptions()
        {
            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("a"));

            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("ASDFGHJKOIUYTTTTTTTa"));
            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("ASDFGHJKOIUYTTTTTTT1"));

            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("A2SDFGHJKOIUYTTTTTTT"));
            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("ASDFGHJKOIUYTTTTTTT2"));

            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("AaaaaSDFGHJKOIUYTTTTTTT"));
            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("ASDFGHJKOIUYTTTTTTTa1aaaa"));

            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("ASDFGH-JKOIUYTTTTTTTa1"));
            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("ASDFGHJKOIUYTTTTTTTa1-"));
            Assert.ThrowsException<NotUpperCase>(() => Reduction.GetReductionString("-ASDFGHJKOIUYTTTTTTTa1-"));
        }
    }
}