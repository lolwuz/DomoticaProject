using Intersoft.Crosslight.ViewModels;

namespace ChartingSample.ViewModels
{
    public class DrawerViewModel : DrawerViewModelBase
    {
        #region Constructors

        public DrawerViewModel()
        {
            this.LeftViewModel = new NavigationViewModel();
			this.CenterViewModel = new ReferenceSample2ViewModel();
        }

        #endregion
    }
}