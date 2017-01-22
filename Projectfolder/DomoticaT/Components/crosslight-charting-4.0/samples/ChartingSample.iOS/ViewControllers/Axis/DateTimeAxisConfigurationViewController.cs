using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(DateTimeAxisConfigurationBindingProvider))]
    public class DateTimeAxisConfigurationViewController : ChartViewSampleController<DateTimeAxisConfigurationViewModel>
    {
        public DateTimeAxisConfigurationViewController()
        {
            this.Title = "DateTime Axis Configuration";
        }
    }
}