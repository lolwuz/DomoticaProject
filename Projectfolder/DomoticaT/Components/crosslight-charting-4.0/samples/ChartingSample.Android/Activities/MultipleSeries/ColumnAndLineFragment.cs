﻿using Android.App;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;
using ChartingSample.ViewModels;

namespace ChartingSample.Android
{
    [Fragment(Label = "Different Type Multiple Series")]
    [ImportBinding(typeof(ColumnAndLineBindingProvider))]
    public class ColumnAndLineFragment : ChartViewSampleFragment<ColumnAndLineViewModel>
    {
    }

}