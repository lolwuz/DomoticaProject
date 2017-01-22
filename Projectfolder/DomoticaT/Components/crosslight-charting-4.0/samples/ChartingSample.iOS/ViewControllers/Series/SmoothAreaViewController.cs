using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(SmoothAreaBindingProvider))]
    public class SmoothAreaViewController : ChartViewSampleController<SmoothAreaViewModel>
    {
        public SmoothAreaViewController()
        {
            this.Title = "Smooth Area Series";
        }
    }
}