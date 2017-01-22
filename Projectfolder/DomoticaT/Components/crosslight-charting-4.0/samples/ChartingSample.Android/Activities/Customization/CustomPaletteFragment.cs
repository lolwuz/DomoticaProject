using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "CustomPalette")]
    [ImportBinding(typeof(CustomPaletteBindingProvider))]
    public class CustomPaletteFragment : ChartViewSampleFragment<CustomPaletteViewModel>
    {
    }

}