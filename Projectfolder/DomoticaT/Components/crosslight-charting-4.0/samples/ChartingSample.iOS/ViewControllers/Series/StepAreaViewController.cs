using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(StepAreaBindingProvider))]
    public class StepAreaViewController : ChartViewSampleController<StepAreaViewModel>
    {
        public StepAreaViewController()
        {
            this.Title = "Step Area Series";
        }
    }
}