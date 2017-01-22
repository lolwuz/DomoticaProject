using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Palette Types")]
    [ImportBinding(typeof(PaletteTypesBindingProvider))]
    public class PaletteTypesFragment : ChartViewSampleFragment<PaletteTypesViewModel>
    {
    }

}