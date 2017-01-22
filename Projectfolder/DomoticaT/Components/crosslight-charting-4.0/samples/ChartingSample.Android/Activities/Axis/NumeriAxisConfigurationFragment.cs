using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Numeric Axis Configuration")]
    [ImportBinding(typeof(NumericAxisConfigurationBindingProvider))]
    public class NumericAxisConfigurationFragment : ChartViewSampleFragment<NumericAxisConfigurationViewModel>
    {
    }

}