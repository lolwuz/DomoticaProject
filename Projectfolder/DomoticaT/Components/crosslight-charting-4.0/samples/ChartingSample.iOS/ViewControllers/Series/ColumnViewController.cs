using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(ColumnBindingProvider))]
    public class ColumnViewController : ChartViewSampleController<ColumnViewModel>
    {
        public ColumnViewController()
        {
            this.Title = "Column Series";
        }
    }
}