using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(DateTimeAxisDateFormatBindingProvider))]
    public class DateTimeAxisDateFormatViewController : ChartViewSampleController<DateTimeAxisDateFormatViewModel>
    {
        public DateTimeAxisDateFormatViewController()
        {
            this.Title = "DateTime Axis Date Format";
        }
    }
}