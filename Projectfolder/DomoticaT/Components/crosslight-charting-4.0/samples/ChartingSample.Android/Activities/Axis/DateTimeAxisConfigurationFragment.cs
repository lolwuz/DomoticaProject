using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "DateTime Axis Configuration")]
    [ImportBinding(typeof(DateTimeAxisConfigurationBindingProvider))]
    public class DateTimeAxisConfigurationFragment : ChartViewSampleFragment<DateTimeAxisConfigurationViewModel>
    {
    }

}