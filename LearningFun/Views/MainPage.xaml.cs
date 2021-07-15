using System.ComponentModel;
using LearningFun.Interfaces;
using Xamarin.Forms;

namespace LearningFun.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            if (CurrentPage is IDynamicTitle page)
            {
                NavigationPage.SetHasNavigationBar(this, true);
                NavigationPage.SetTitleView(this, page.GetTitle());
                return;
            }

            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}
