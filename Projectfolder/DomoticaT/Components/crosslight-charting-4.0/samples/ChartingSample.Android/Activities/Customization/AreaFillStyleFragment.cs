using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Area Fill Style")]
    [ImportBinding(typeof(AreaFillStyleBindingProvider))]
    public class AreaFillStyleFragment : ChartViewSampleFragment<AreaFillStyleViewModel>
    {
    }

}