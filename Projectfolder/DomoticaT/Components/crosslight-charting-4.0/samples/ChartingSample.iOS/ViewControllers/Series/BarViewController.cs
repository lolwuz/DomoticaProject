using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(BarBindingProvider))]
    public class BarViewController : ChartViewSampleController<BarViewModel>
    {
        public BarViewController()
        {
            this.Title = "Bar Series";
        }
    }
}