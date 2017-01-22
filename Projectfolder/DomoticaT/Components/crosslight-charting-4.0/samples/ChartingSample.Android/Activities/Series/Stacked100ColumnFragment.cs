using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Stacked 100 Column Series")]
    [ImportBinding(typeof(Stacked100ColumnBindingProvider))]
    public class Stacked100ColumnFragment : ChartViewSampleFragment<Stacked100ColumnViewModel>
    {
    }

}