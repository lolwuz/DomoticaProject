using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(AlternatingIndependentGridLinesBindingProvider))]
    public class AlternatingIndependentGridLinesViewController : ChartViewSampleController<AlternatingIndependentGridLinesViewModel>
    {
        public AlternatingIndependentGridLinesViewController()
        {
            this.Title = "Alternating Independent Grid Lines";
        }
    }
}