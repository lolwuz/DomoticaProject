using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(StackedLineBindingProvider))]
    public class StackedLineViewController : ChartViewSampleController<StackedLineViewModel>
    {
        public StackedLineViewController()
        {
            this.Title = "Stacked Line Series";
        }
    }
}