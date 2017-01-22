using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(AreaBindingProvider))]
    public class AreaViewController : ChartViewSampleController<AreaViewModel>
    {
        public AreaViewController()
        {
            this.Title = "Area Series";
        }
    }
}