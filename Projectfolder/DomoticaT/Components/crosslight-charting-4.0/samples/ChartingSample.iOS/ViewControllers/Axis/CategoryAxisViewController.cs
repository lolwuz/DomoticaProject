using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(CategoryAxisBindingProvider))]
    public class CategoryAxisViewController : ChartViewSampleController<CategoryAxisViewModel>
    {
        public CategoryAxisViewController()
        {
            this.Title = "Category Axis";
        }
    }
}