using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Alternating Dependent GridLines")]
    [ImportBinding(typeof(AlternatingDependentGridLinesBindingProvider))]
    public class AlternatingDependentGridLinesFragment : ChartViewSampleFragment<AlternatingDependentGridLinesViewModel>
    {
    }

}