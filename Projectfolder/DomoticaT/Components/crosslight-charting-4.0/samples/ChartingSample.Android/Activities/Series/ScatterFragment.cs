using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Scatter Series")]
    [ImportBinding(typeof(ScatterBindingProvider))]
    public class ScatterFragment : ChartViewSampleFragment<ScatterViewModel>
    {
    }

}