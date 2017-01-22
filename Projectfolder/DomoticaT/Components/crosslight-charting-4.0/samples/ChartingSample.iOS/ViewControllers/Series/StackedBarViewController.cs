using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(StackedBarBindingProvider))]
    public class StackedBarViewController : ChartViewSampleController<StackedBarViewModel>
    {
        public StackedBarViewController()
        {
            this.Title = "Stacked Bar Series";
        }
    }
}