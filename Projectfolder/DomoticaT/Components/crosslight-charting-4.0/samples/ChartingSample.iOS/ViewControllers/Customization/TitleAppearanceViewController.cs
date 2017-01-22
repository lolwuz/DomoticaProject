using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(TitleAppearanceBindingProvider))]
    public class TitleAppearanceViewController : ChartViewSampleController<TitleAppearanceViewModel>
    {
        public TitleAppearanceViewController()
        {
            this.Title = "Title Appearance";
        }
    }
}