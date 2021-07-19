using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearningFun.Views.TitleViews
{
    public partial class StoriesTitleView : ContentView
    {
        public StoriesTitleView()
        {
            InitializeComponent();
            // animate to the new value over 750 milliseconds using Linear easing
            //progressIndicator.ProgressTo(0.7, 3000, Easing.SinOut);
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            _ = UpdateProgressValue();
        }

        private async Task UpdateProgressValue()
        {
          await  progressIndicator.ProgressTo(0.7, 3000, Easing.SinOut);
            //progressIndicator.Progress = 0.9;
            //progressIndicator.TrackColor = Color.Green;
            //await Navigation.PushAsync(page: new DragAndDropGesture());
        }
    }
}
