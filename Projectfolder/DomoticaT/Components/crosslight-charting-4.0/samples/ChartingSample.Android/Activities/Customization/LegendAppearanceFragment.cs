using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Legend Appearance")]
    [ImportBinding(typeof(LegendAppearanceBindingProvider))]
    public class LegendAppearanceFragment : ChartViewSampleFragment<LegendAppearanceViewModel>
    {
    }

}