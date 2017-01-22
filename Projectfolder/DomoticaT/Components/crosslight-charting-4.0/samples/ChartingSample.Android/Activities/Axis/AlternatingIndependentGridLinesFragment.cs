using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Alternating Independent GridLines")]
    [ImportBinding(typeof(AlternatingIndependentGridLinesBindingProvider))]
    public class AlternatingIndependentGridLinesFragment : ChartViewSampleFragment<AlternatingIndependentGridLinesViewModel>
    {
    }

}