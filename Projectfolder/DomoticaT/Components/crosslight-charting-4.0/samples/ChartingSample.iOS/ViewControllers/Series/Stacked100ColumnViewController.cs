using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(Stacked100ColumnBindingProvider))]
    public class Stacked100ColumnViewController : ChartViewSampleController<Stacked100ColumnViewModel>
    {
        public Stacked100ColumnViewController()
        {
            this.Title = "Stacked 100 Column Series";
        }
    }
}