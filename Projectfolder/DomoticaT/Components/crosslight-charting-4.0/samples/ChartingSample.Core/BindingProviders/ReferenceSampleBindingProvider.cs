using Intersoft.Crosslight;
using Intersoft.Crosslight.UI.DataVisualization;

namespace ChartingSample
{
    public class ReferenceSampleBindingProvider : BindingProvider
    {
        #region Constructors

        public ReferenceSampleBindingProvider()
        {
            this.AddBinding("ActionPresenterButton", BindableProperties.CommandProperty, "ShowPresenterCommand");
            this.AddBinding("Label2", BindableProperties.TextProperty, new BindingDescription("TotalUser", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("Label4", BindableProperties.TextProperty, new BindingDescription("TotalDownload", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("Label6", BindableProperties.TextProperty, new BindingDescription("TotalUpload", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("Label8", BindableProperties.TextProperty, new BindingDescription("TotalCrashes", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("ChartView", ChartProperties.ChartProperty, new BindingDescription("Chart", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("ChartView2", ChartProperties.ChartProperty, new BindingDescription("Chart2", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("ChartView3", ChartProperties.ChartProperty, new BindingDescription("Chart3", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("ChartView4", ChartProperties.ChartProperty, new BindingDescription("Chart4", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
        }

        #endregion
    }
}