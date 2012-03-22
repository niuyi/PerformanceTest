using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xunit;

namespace PerformanceTest
{
    public class PerformanceFacts
    {
        [Fact]
        public void counters()
        {
            var categories =
                PerformanceCounterCategory.GetCategories();
            Console.WriteLine(categories.Length);
            foreach (var category in categories)
            {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
