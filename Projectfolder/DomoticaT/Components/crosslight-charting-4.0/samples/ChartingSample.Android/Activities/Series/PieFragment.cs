using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Pie Series")]
    [ImportBinding(typeof(PieBindingProvider))]
    public class PieFragment : ChartViewSampleFragment<PieViewModel>
    {
    }

}