using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Stacked Area Series")]
    [ImportBinding(typeof(StackedAreaBindingProvider))]
    public class StackedAreaFragment : ChartViewSampleFragment<StackedAreaViewModel>
    {
    }

}