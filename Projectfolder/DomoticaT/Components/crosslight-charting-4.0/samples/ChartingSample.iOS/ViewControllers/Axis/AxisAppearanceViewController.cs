using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(AxisAppearanceBindingProvider))]
    public class AxisAppearanceViewController : ChartViewSampleController<AxisAppearanceViewModel>
    {
        public AxisAppearanceViewController()
        {
            this.Title = "Axis Appearance";
        }
    }
}