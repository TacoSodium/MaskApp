using System;
using Xunit;
using MaskAPI.Models;

namespace MaskTests
{
    public class UnitTest1
    {
        [Fact]
        public void ConstructorTest()
        {
            try
            {
                Mask newMask = new Mask("m-999", 1, "Black", true, false, "Spots", true, 30.00);
            }
            catch (Exception ex)
            {
                System.Environment.Exit(1);
            }

            Assert.True(true);
        }
    }
}
