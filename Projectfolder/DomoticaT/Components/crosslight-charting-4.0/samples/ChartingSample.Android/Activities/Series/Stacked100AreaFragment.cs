using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Stacked 100 Area Series")]
    [ImportBinding(typeof(Stacked100AreaBindingProvider))]
    public class Stacked100AreaFragment : ChartViewSampleFragment<Stacked100AreaViewModel>
    {
    }

}