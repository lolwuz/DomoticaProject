using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Numeric Axis")]
    [ImportBinding(typeof(NumericAxisBindingProvider))]
    public class NumericAxisFragment : ChartViewSampleFragment<NumericAxisViewModel>
    {
    }

}