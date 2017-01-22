using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Zoom Configuration")]
    [ImportBinding(typeof(ZoomConfigurationBindingProvider))]
    public class ZoomConfigurationFragment : ChartViewSampleFragment<ZoomConfigurationViewModel>
    {
    }

}