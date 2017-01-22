using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "ColumnBar Fill Style")]
    [ImportBinding(typeof(ColumnBarFillStyleBindingProvider))]
    public class ColumnBarFillStyleFragment : ChartViewSampleFragment<ColumnBarFillStyleViewModel>
    {
    }

}