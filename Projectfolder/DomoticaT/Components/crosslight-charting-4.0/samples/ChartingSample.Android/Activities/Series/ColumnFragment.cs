using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Column Series")]
    [ImportBinding(typeof(ColumnBindingProvider))]
    public class ColumnFragment : ChartViewSampleFragment<ColumnViewModel>
    {
    }

}