using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Stacked 100 Line Series")]
    [ImportBinding(typeof(Stacked100LineBindingProvider))]
    public class Stacked100LineFragment : ChartViewSampleFragment<Stacked100LineViewModel>
    {
    }

}