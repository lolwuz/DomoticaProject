using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(NumericAxisNumberFormatBindingProvider))]
    public class NumericAxisNumberFormatViewController : ChartViewSampleController<NumericAxisNumberFormatViewModel>
    {
        public NumericAxisNumberFormatViewController()
        {
            this.Title = "Numeric Axis Number Format";
        }
    }
}