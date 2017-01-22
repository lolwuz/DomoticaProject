using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(AdditionalDateTimeGridLinesBindingProvider))]
    public class AdditionalDateTimeGridLinesViewController : ChartViewSampleController<AdditionalDateTimeGridLinesViewModel>
    {
        public AdditionalDateTimeGridLinesViewController()
        {
            this.Title = "Additional DateTime Grid Lines";
        }
    }
}