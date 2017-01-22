using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(ColumnBarFillStyleBindingProvider))]
    public class ColumnBarFillStyleViewController : ChartViewSampleController<ColumnBarFillStyleViewModel>
    {
        public ColumnBarFillStyleViewController()
        {
            this.Title = "Column Bar Fill Style";
        }
    }
}