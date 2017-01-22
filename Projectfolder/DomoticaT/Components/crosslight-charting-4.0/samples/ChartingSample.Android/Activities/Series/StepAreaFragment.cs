using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Step Area Series")]
    [ImportBinding(typeof(StepAreaBindingProvider))]
    public class StepAreaFragment : ChartViewSampleFragment<StepAreaViewModel>
    {
    }

}