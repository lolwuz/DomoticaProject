using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(DoughnutBindingProvider))]
    public class DoughnutViewController : ChartViewSampleController<DoughnutViewModel>
    {
        public DoughnutViewController()
        {
            this.Title = "Doughnut Series";
        }
    }
}