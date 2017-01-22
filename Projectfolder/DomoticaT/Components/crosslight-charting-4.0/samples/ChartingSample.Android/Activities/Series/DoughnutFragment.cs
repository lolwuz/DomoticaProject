using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Doughnut Series")]
    [ImportBinding(typeof(DoughnutBindingProvider))]
    public class DoughnutFragment : ChartViewSampleFragment<DoughnutViewModel>
    {
    }

}