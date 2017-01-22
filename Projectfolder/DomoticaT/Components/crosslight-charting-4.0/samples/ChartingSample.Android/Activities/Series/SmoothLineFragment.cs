using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Smooth Line Series")]
    [ImportBinding(typeof(SmoothLineBindingProvider))]
    public class SmoothLineFragment : ChartViewSampleFragment<SmoothLineViewModel>
    {
    }

}