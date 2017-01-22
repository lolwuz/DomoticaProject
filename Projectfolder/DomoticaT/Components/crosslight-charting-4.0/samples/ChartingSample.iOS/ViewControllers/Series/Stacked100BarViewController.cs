using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(Stacked100BarBindingProvider))]
    public class Stacked100BarViewController : ChartViewSampleController<Stacked100BarViewModel>
    {
        public Stacked100BarViewController()
        {
            this.Title = "Stacked 100 Bar Series";
        }
    }
}