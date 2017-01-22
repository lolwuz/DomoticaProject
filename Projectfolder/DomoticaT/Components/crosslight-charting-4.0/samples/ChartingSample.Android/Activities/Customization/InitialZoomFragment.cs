using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Initial Zoom")]
    [ImportBinding(typeof(InitialZoomBindingProvider))]
    public class InitialZoomFragment : ChartViewSampleFragment<InitialZoomViewModel>
    {
    }

}