using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "NumericAxis Number Format")]
    [ImportBinding(typeof(NumericAxisNumberFormatBindingProvider))]
    public class NumericAxisNumberFormatFragment : ChartViewSampleFragment<NumericAxisNumberFormatViewModel>
    {
    }

}