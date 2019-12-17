using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using apprentice_bootcamp_fundamentals_2;

namespace UnitTests
{
    [TestFixture]
    public class AutoTraderBillTests
    {
        [Test]
        public void GivenAPrivateIndividualHasThreeAdvertsThenTheyPaySixty()
        {
            Bill bill = new Bill();

            int total = bill.CalculateBill(false, 3, 0);


            Assert.AreEqual(60, total);
        }

        [Test]
        public void GivenAPrivateIndividualHasOneAdvertAndOneProductThenTheyPayThirty()
        {
            Bill bill = new Bill();

            int total = bill.CalculateBill(false, 1, 1);

            Assert.AreEqual(30, total);
        }

        [Test]
        public void GivenADealerHasTwentyAdvertsAndOneProductThenTheyPayTwelveHundred()
        {
            Bill bill = new Bill();

            int total = bill.CalculateBill(true, 20, 1);

            Assert.AreEqual(1200, total);
        }

        [Test]
        public void GivenADealerHasOneThousandAdvertsAndTwoProductsThenTheyPaySeventyThousand()
        {
            Bill bill = new Bill();

            int total = bill.CalculateBill(true, 1000, 2);

            Assert.AreEqual(70000, total);
        }
    }
}
