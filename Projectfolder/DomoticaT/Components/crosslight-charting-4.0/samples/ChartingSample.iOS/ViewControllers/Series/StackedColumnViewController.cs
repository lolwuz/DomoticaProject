using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(StackedColumnBindingProvider))]
    public class StackedColumnViewController : ChartViewSampleController<StackedColumnViewModel>
    {
        public StackedColumnViewController()
        {
            this.Title = "Stacked Column Series";
        }
    }
}