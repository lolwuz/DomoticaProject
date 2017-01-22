using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Date Time Axis")]
    [ImportBinding(typeof(DateTimeAxisBindingProvider))]
    public class DateTimeAxisFragment : ChartViewSampleFragment<DateTimeAxisViewModel>
    {
    }

}