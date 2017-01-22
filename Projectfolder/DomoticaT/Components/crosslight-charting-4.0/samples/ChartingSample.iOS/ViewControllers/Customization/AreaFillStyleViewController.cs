using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(AreaFillStyleBindingProvider))]
    public class AreaFillStyleViewController : ChartViewSampleController<AreaFillStyleViewModel>
    {
        public AreaFillStyleViewController()
        {
            this.Title = "Area Fill Style";
        }
    }
}