using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(GridLinesStyleBindingProvider))]
    public class GridLinesStyleViewController : ChartViewSampleController<GridLinesStyleViewModel>
    {
        public GridLinesStyleViewController()
        {
            this.Title = "Grid Lines Style";
        }
    }
}