using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Stacked 100 Bar Series")]
    [ImportBinding(typeof(Stacked100BarBindingProvider))]
    public class Stacked100BarFragment : ChartViewSampleFragment<Stacked100BarViewModel>
    {
    }

}