using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(ZoomConfigurationBindingProvider))]
    public class ZoomConfigurationViewController : ChartViewSampleController<ZoomConfigurationViewModel>
    {
        public ZoomConfigurationViewController()
        {
            this.Title = "Zoom Configuration";
        }
    }
}