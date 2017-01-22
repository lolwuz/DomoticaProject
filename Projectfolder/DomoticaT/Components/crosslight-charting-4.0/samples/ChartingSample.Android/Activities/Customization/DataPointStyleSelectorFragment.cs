using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "DataPoint Style Selector")]
    [ImportBinding(typeof(DataPointStyleSelectorBindingProvider))]
    public class DataPointStyleSelectorFragment : ChartViewSampleFragment<DataPointStyleSelectorViewModel>
    {
    }

}