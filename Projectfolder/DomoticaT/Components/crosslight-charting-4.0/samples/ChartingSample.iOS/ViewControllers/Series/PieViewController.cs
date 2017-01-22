using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(PieBindingProvider))]
    public class PieViewController : ChartViewSampleController<PieViewModel>
    {
        public PieViewController()
        {
            this.Title = "Pie Series";
        }
    }
}