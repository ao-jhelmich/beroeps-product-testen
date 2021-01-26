using NUnit.Framework;

namespace Shop.Tests
{
    public class Tests
    {
        public DetermineShippingCosts determineShippingCosts;

        [SetUp]
        public void Setup()
        {
            determineShippingCosts = new DetermineShippingCosts();
        }

        [Test]
        public void when_no_calculation_is_needed_return_0()
        {
            double result = determineShippingCosts.ShippingCosts(false, "", 1.1);
            
            Assert.AreEqual(0, result);
        }
        
        [Test]
        public void when_total_price_is_higher_then_1500_return_0()
        {
            double result = determineShippingCosts.ShippingCosts(true, "", 1500);

            Assert.AreEqual(0, result);
        }
        
        
        [Test]
        public void when_shipping_type_is_ground()
        {
            double result = determineShippingCosts.ShippingCosts(true, "Ground", 1);

            Assert.AreEqual(100, result);
        } 
        
        [Test]
        public void when_shipping_type_is_in_store()
        {
            double result = determineShippingCosts.ShippingCosts(true, "InStore", 1);

            Assert.AreEqual(50, result);
        } 
        
        [Test]
        public void when_shipping_type_is_next_day_air()
        {
            double result = determineShippingCosts.ShippingCosts(true, "NextDayAir", 1);

            Assert.AreEqual(250, result);
        }  
        
        [Test]
        public void when_shipping_type_is_second_day_air()
        {
            double result = determineShippingCosts.ShippingCosts(true, "SecondDayAir", 1);


            Assert.AreEqual(125, result);
        }
    }
}