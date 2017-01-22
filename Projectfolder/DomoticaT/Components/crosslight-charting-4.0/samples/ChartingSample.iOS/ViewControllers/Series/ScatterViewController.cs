using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(ScatterBindingProvider))]
    public class ScatterViewController : ChartViewSampleController<ScatterViewModel>
    {
        public ScatterViewController()
        {
            this.Title = "Scatter Series";
        }
    }
}