using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(PaletteOrderBindingProvider))]
    public class PaletteOrderViewController : ChartViewSampleController<PaletteOrderViewModel>
    {
        public PaletteOrderViewController()
        {
            this.Title = "Palette Order";
        }
    }
}