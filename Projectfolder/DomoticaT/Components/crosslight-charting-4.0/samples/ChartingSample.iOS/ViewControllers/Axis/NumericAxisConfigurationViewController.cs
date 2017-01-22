using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(NumericAxisConfigurationBindingProvider))]
    public class NumericAxisConfigurationViewController : ChartViewSampleController<NumericAxisConfigurationViewModel>
    {
        public NumericAxisConfigurationViewController()
        {
            this.Title = "Numeric Axis Configuration";
        }
    }
}