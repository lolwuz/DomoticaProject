using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(InitialZoomBindingProvider))]
    public class InitialZoomViewController : ChartViewSampleController<InitialZoomViewModel>
    {
        public InitialZoomViewController()
        {
            this.Title = "Initial Zoom";
        }
    }
}