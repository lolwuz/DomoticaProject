using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(SmoothLineBindingProvider))]
    public class SmoothLineViewController : ChartViewSampleController<SmoothLineViewModel>
    {
        public SmoothLineViewController()
        {
            this.Title = "Smooth Line Series";
        }
    }
}