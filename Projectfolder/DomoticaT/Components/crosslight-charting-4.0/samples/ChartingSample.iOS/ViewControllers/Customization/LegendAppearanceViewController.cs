using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(LegendAppearanceBindingProvider))]
    public class LegendAppearanceViewController : ChartViewSampleController<LegendAppearanceViewModel>
    {
        public LegendAppearanceViewController()
        {
            this.Title = "Legend Appearance";
        }
    }
}