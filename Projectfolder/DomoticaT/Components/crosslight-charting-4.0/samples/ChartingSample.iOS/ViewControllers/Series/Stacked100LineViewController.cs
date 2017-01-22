using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(Stacked100LineBindingProvider))]
    public class Stacked100LineViewController : ChartViewSampleController<Stacked100LineViewModel>
    {
        public Stacked100LineViewController()
        {
            this.Title = "Stacked 100 Line Series";
        }
    }
}