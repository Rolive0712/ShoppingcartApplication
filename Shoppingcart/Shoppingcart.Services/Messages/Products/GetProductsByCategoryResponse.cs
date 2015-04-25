﻿using Shoppingcart.Services.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart.Services.Messages
{
    public class GetProductsByCategoryResponse
    {
        public string SelectedCategoryName { get; set; }
        public int SelectedCategory { get; set; }
        public IEnumerable<RefinementGroup> RefinementGroups { get; set; }
        public int NumberOfTitlesFound { get; set; }
        public int TotalNumberOfPages { get; set; }
        public int CurrentPage { get; set; }
        public IEnumerable<ProductSummaryView> Products { get; set; }
    }
}
