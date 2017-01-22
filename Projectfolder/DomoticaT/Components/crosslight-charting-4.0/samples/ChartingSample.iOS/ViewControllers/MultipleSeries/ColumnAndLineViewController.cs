using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(ColumnAndLineBindingProvider))]
    public class ColumnAndLineViewController : ChartViewSampleController<ColumnAndLineViewModel>
    {
        public ColumnAndLineViewController()
        {
            this.Title = "Multiple Different Type Series";
        }
    }
}