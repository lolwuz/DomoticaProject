using ChartingSample.ViewModels;
using Intersoft.Crosslight;
using Intersoft.Crosslight.Android;

namespace ChartingSample.Android
{
    [ImportBinding(typeof(NavigationBindingProvider))]
    public class NavigationListFragment : ListFragment<NavigationViewModel>
    {
        #region Properties

        public override ListViewInteraction InteractionMode
        {
            get
            {
                return ListViewInteraction.Navigation;
            }
        }

        protected override int GroupItemLayoutId
        {
            get { return Resource.Layout.listgroupsectionheaderlayout; }
        }

        #endregion

        #region Methods

        protected override void InitializeView()
        {
            base.InitializeView();

            this.RegisterViewIdentifier("TableView", this.ListView);
        }

        #endregion
    }
}