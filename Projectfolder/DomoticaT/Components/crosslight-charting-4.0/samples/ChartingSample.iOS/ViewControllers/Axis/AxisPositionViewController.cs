using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(AxisPositionBindingProvider))]
    public class AxisPositionViewController : ChartViewSampleController<AxisPositionViewModel>
    {
        public AxisPositionViewController()
        {
            this.Title = "Axis Position";
        }
    }
}