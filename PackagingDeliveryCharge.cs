using NUnit.Framework;
using System.Collections.Generic;
using PackagingAndDelivery.Models;
using Moq;
using PackagingAndDelivery.Controllers;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Payment.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Integral", 2, 600)]
        [TestCase("Accessory", 2, 300)]
        [TestCase("Mirror", 2, 0)]
        public void Test_GetPackagingDeliveryCharge_Action(string item, int count, int charges)
        {
            GetPackagingDeliveryChargeController controller = new GetPackagingDeliveryChargeController();
            var result = controller.GetPackagingDeliveryCharge(item, count);
            Assert.AreEqual(charges, result);
        }
    }
}