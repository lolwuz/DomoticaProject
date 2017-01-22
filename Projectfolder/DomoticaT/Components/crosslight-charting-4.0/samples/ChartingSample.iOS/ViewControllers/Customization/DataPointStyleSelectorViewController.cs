using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(DataPointStyleSelectorBindingProvider))]
    public class DataPointStyleSelectorViewController : ChartViewSampleController<DataPointStyleSelectorViewModel>
    {
        public DataPointStyleSelectorViewController()
        {
            this.Title = "Data Point Style Selector";
        }
    }
}