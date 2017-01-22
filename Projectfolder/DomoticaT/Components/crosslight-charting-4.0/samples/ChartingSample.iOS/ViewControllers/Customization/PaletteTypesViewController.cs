using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(PaletteTypesBindingProvider))]
    public class PaletteTypesViewController : ChartViewSampleController<PaletteTypesViewModel>
    {
        public PaletteTypesViewController()
        {
            this.Title = "Palette Types";
        }
    }
}