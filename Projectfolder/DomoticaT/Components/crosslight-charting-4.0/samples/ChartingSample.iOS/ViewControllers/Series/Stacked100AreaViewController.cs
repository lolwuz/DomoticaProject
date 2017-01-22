using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(Stacked100AreaBindingProvider))]
    public class Stacked100AreaViewController : ChartViewSampleController<Stacked100AreaViewModel>
    {
        public Stacked100AreaViewController()
        {
            this.Title = "Stacked 100 Area Series";
        }
    }
}