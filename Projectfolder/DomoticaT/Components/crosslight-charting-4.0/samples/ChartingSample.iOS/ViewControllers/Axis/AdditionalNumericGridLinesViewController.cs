using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(AdditionalNumericGridLinesBindingProvider))]
    public class AdditionalNumericGridLinesViewController : ChartViewSampleController<AdditionalNumericGridLinesViewModel>
    {
        public AdditionalNumericGridLinesViewController()
        {
            this.Title = "Additional Numeric Grid Lines";
        }
    }
}