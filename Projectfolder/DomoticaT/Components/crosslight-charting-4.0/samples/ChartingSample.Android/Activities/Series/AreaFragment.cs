using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Area Series")]
    [ImportBinding(typeof(AreaBindingProvider))]
    public class AreaFragment : ChartViewSampleFragment<AreaViewModel>
    {
    }

}