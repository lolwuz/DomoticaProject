using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(LineBindingProvider))]
    public class LineViewController : ChartViewSampleController<LineViewModel>
    {
        public LineViewController()
        {
            this.Title = "Line Series";
        }
    }
}