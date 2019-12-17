﻿using System;
using apprentice_bootcamp_fundamentals_2;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class WhenTestingThingy
    {

        [Test]
        public void ItWorks()
        {
            Thingy thingy = new Thingy();
            string result = thingy.FullFizzBuzzResult();
            Assert.That(string.Equals(result, DataTypeConverter.ParseHexBinary("3120322046697a7a20342042757a7a2046697a7a203720382046697a7a2042757a7a2031312046697a7a2031332031342046697a7a42757a7a2031362031372046697a7a2031392042757a7a2046697a7a2032322032332046697a7a2042757a7a2032362046697a7a2032382032392046697a7a42757a7a2033312033322046697a7a2033342042757a7a2046697a7a2033372033382046697a7a2042757a7a2034312046697a7a2034332034342046697a7a42757a7a2034362034372046697a7a2034392042757a7a2046697a7a2035322035332046697a7a2042757a7a2035362046697a7a2035382035392046697a7a42757a7a2036312036322046697a7a2036342042757a7a2046697a7a2036372036382046697a7a2042757a7a2037312046697a7a2037332037342046697a7a42757a7a2037362037372046697a7a2037392042757a7a2046697a7a2038322038332046697a7a2042757a7a2038362046697a7a2038382038392046697a7a42757a7a2039312039322046697a7a2039342042757a7a2046697a7a2039372039382046697a7a2042757a7a")));            
        }
    }
}
