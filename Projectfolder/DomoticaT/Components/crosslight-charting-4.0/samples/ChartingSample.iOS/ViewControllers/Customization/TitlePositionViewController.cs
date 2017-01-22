using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(TitlePositionBindingProvider))]
    public class TitlePositionViewController : ChartViewSampleController<TitlePositionViewModel>
    {
        public TitlePositionViewController()
        {
            this.Title = "Title Position";
        }
    }
}