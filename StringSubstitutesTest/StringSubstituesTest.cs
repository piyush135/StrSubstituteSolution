using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using StringsubstitutesSample;
using StringSubstitutesTest.TestData;

namespace StringSubstitutesTest
{
    [TestClass]
    public class StringSubstituesTest
    {
        [TestMethod]
        public void StringSubstituesTest_ReturnOk()
        {
            var prefixChar = StringSubStituteMockData.Prefix;
            var surfixChar = StringSubStituteMockData.SurFix;

            var strinSubStitutuesService = new Mock<Substitutes>(prefixChar, surfixChar);           

            var template = StringSubStituteMockData.GetSource();

            var dicts = StringSubStituteMockData.ValueMap;

            var outPutStr = StringSubStituteMockData.GetOutPutSource();
            var actionResult = strinSubStitutuesService.Object.Replace(template, dicts);

            Assert.AreEqual(actionResult, outPutStr);
        }

        [TestMethod]
        public void StringSubstituesTest_DifferentValueMap()
        {
            var prefixChar = StringSubStituteMockData.Prefix;
            var surfixChar = StringSubStituteMockData.SurFix;

            var strinSubStitutuesService = new Mock<Substitutes>(prefixChar, surfixChar);           

            var template = StringSubStituteMockData.GetSource();

            var dicts = StringSubStituteMockData.DifferntValueMapFromSource;

            var outPutStr = StringSubStituteMockData.DiffernetOutPutSource();
            var actionResult = strinSubStitutuesService.Object.Replace(template, dicts);

            Assert.AreEqual(actionResult, outPutStr);
        }

        [TestMethod]
        public void StringSubstituesTest_DifferentPrefix()
        {
            var prefixChar = StringSubStituteMockData.DifferentPrefix;
            var surfixChar = StringSubStituteMockData.SurFix;
            var strinSubStitutuesService = new Mock<Substitutes>(prefixChar, surfixChar);
            
            var template = StringSubStituteMockData.GetSourceForDiffernetPrefix();

            var dicts = StringSubStituteMockData.DifferntValueMapFromSource;

            var outPutStr = StringSubStituteMockData.DiffernetOutPutSourcefromPrefix();
            var actionResult = strinSubStitutuesService.Object.Replace(template, dicts);

            Assert.AreEqual(actionResult, outPutStr);
        }

        [TestMethod]
        public void StringSubstituesTest_DifferentSurfix()
        {
            var prefixChar = StringSubStituteMockData.Prefix;
            var surfixChar = StringSubStituteMockData.DifferentSurFix;
            var strinSubStitutuesService = new Mock<Substitutes>(prefixChar, surfixChar);
            
            var template = StringSubStituteMockData.GetSourceForDiffernetSurfix();

            var dicts = StringSubStituteMockData.DifferntValueMapFromSource;

            var outPutStr = StringSubStituteMockData.DiffernetOutPutSourcefromSurfix();
            var actionResult = strinSubStitutuesService.Object.Replace(template, dicts);

            Assert.AreEqual(actionResult, outPutStr);
        }

        [TestMethod]
        public void StringSubstituesTest_DifferentPurfixaNDSurfix()
        {
            var prefixChar = StringSubStituteMockData.DifferentPrefix;
            var surfixChar = StringSubStituteMockData.DifferentSurFix;
            var strinSubStitutuesService = new Mock<Substitutes>(prefixChar, surfixChar);
            
            var template = StringSubStituteMockData.GetSourceForDiffernetPurfixAndSurfix();

            var dicts = StringSubStituteMockData.ValueMap;

            var outPutStr = StringSubStituteMockData.GetOutPutSource();
            var actionResult = strinSubStitutuesService.Object.Replace(template, dicts);

            Assert.AreEqual(actionResult, outPutStr);
        }

    }
}
