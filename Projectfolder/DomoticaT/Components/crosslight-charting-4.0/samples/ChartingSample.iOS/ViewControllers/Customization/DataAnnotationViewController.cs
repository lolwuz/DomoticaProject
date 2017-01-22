using System;
using ChartingSample.ViewModels;
using CoreGraphics;
using Intersoft.Crosslight;
using Intersoft.Crosslight.iOS;
using Intersoft.Crosslight.UI.DataVisualization.iOS;
using UIKit;

namespace ChartingSample.iOS
{
    [ImportBinding(typeof(DataAnnotationBindingProvider))]
    public class DataAnnotationViewController : ChartViewSampleController<DataAnnotationViewModel>
    {
        public DataAnnotationViewController()
        {
            this.Title = "Data Annotation";
        }
    }
}