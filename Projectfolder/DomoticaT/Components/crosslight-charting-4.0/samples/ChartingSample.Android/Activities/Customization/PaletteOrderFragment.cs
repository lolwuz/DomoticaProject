using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Palette Order")]
    [ImportBinding(typeof(PaletteOrderBindingProvider))]
    public class PaletteOrderFragment : ChartViewSampleFragment<PaletteOrderViewModel>
    {
    }

}