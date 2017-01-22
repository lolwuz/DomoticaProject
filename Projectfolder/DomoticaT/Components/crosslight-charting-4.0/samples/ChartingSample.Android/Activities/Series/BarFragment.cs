using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Bar Series")]
    [ImportBinding(typeof(BarBindingProvider))]
    public class BarFragment : ChartViewSampleFragment<BarViewModel>
    {
    }

}