using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(DateTimeAxisBindingProvider))]
    public class DateTimeAxisViewController : ChartViewSampleController<DateTimeAxisViewModel>
    {
        public DateTimeAxisViewController()
        {
            this.Title = "Date Time Axis";
        }
    }
}