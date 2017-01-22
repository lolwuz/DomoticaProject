using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Axis Appearance")]
    [ImportBinding(typeof(AxisAppearanceBindingProvider))]
    public class AxisAppearanceFragment : ChartViewSampleFragment<AxisAppearanceViewModel>
    {
    }

}