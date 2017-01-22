using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Stacked Bar Series")]
    [ImportBinding(typeof(StackedBarBindingProvider))]
    public class StackedBarFragment : ChartViewSampleFragment<StackedBarViewModel>
    {
    }

}