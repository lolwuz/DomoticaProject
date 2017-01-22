using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(NumericAxisBindingProvider))]
    public class NumericAxisViewController : ChartViewSampleController<NumericAxisViewModel>
    {
        public NumericAxisViewController()
        {
            this.Title = "Numeric Axis";
        }
    }
}