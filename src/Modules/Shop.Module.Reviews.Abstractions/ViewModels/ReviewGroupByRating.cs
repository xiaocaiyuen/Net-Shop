using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Module.Reviews.Abstractions.ViewModels
{
    public class ReviewGroupByRating
    {
        public int Rating { get; set; }

        public int Count { get; set; }
    }
}
