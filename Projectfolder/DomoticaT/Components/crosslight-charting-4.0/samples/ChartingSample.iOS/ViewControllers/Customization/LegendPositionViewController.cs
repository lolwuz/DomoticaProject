using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(LegendPositionBindingProvider))]
    public class LegendPositionViewController : ChartViewSampleController<LegendPositionViewModel>
    {
        public LegendPositionViewController()
        {
            this.Title = "Legend Position";
        }
    }
}