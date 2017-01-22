using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(CustomPaletteBindingProvider))]
    public class CustomPaletteViewController : ChartViewSampleController<CustomPaletteViewModel>
    {
        public CustomPaletteViewController()
        {
            this.Title = "Custom Palette";
        }
    }
}