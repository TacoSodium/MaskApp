using System;
using Xunit;
using MaskAPI.Models;

namespace MaskTests
{
    public class OrderTest
    {
        Mask mask1 = new Mask("m-999", 1, "Black", true, false, "Spots", true, 30.00);
        Mask mask2 = new Mask("m-456", 2, "Blue", false, true, "Swirls", false, 1.00);
        Mask mask3 = new Mask("m-900", 3, "Purple", false, false, "Flowers", true, 15.00);

        [Fact]
        public void SetPriceTest()
        {
            Order order1 = new Order(mask1, 2);
            Order order2 = new Order(mask3, 3);

            Assert.Equal(60.00, order1.Price);
            Assert.Equal(45.00, order2.Price);
        }

        [Fact]
        public void GenerateOrderNoTest()
        {
            Order order1 = new Order(mask1, 2);
            Order order2 = new Order(mask3, 3);

            int num1 = order1.GenerateOrderNo();
            int num2 = order2.GenerateOrderNo();
            int num3 = order1.GenerateOrderNo();
            int num4 = order2.GenerateOrderNo();

            if (num1 == num2 || num1 == num3 || num1 == num4 || num2 == num3 || num2 == num4 || num3 == num4)
            {
                Assert.True(false);
            }

            if ((num1 >= 1000 && num1 <= 10000) && (num2 >= 1000 && num2 <= 10000) && (num3 >= 1000 && num3 <= 10000) && (num4 >= 1000 && num4 <= 10000))
            {
                Assert.True(true);
            }
            else
            {
                Assert.True(false);
            }
        }
    }
}