using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRating.Tests
{
    [TestClass()]
    public class MenuTests
    {
        Menu menu = new Menu();
        [TestMethod()]
        public void FindReviewsByReviewerTest()
        {
            int name = 563;

            Assert.AreEqual(menu.FindReviewsByReviewer(name), 14);
        }
    }
}