using Intersoft.Crosslight;
using Intersoft.Crosslight.UI.DataVisualization;

namespace ChartingSample
{
    public class ReferenceSample2BindingProvider : BindingProvider
    {
        #region Constructors

        public ReferenceSample2BindingProvider()
        {
            this.AddBinding("ActionPresenterButton", BindableProperties.CommandProperty, "ShowPresenterCommand");
            this.AddBinding("ChartView", ChartProperties.ChartProperty, new BindingDescription("Chart", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("ChartView2", ChartProperties.ChartProperty, new BindingDescription("Chart2", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
            this.AddBinding("ChartView3", ChartProperties.ChartProperty, new BindingDescription("Chart3", BindingMode.TwoWay, UpdateSourceTrigger.PropertyChanged));
        }

        #endregion
    }
}