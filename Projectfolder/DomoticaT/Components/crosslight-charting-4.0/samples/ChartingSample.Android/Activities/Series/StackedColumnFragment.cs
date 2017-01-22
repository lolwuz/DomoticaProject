using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Stacked Column Series")]
    [ImportBinding(typeof(StackedColumnBindingProvider))]
    public class StackedColumnFragment : ChartViewSampleFragment<StackedColumnViewModel>
    {
    }

}