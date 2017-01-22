using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(AlternatingDependentGridLinesBindingProvider))]
    public class AlternatingDependentGridLinesViewController : ChartViewSampleController<AlternatingDependentGridLinesViewModel>
    {
        public AlternatingDependentGridLinesViewController()
        {
            this.Title = "Alternating Dependent Grid Lines";
        }
    }
}