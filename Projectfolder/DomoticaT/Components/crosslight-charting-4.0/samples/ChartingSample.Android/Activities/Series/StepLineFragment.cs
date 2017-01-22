using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Step Line Series")]
    [ImportBinding(typeof(StepLineBindingProvider))]
    public class StepLineFragment : ChartViewSampleFragment<StepLineViewModel>
    {
    }

}