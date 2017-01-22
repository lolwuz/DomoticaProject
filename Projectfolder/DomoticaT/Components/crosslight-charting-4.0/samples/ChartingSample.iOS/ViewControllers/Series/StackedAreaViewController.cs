using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(StackedAreaBindingProvider))]
    public class StackedAreaViewController : ChartViewSampleController<StackedAreaViewModel>
    {
        public StackedAreaViewController()
        {
            this.Title = "Stacked Area Series";
        }
    }
}