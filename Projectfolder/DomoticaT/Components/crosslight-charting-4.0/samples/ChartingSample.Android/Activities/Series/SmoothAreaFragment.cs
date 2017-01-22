using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Smooth Area Series")]
    [ImportBinding(typeof(SmoothAreaBindingProvider))]
    public class SmoothAreaFragment : ChartViewSampleFragment<SmoothAreaViewModel>
    {
    }

}