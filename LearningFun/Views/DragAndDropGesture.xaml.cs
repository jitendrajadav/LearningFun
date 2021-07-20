
using Xamarin.Forms;

namespace LearningFun.Views
{
    public partial class DragAndDropGesture : ContentPage
    {
        public DragAndDropGesture()
        {
            InitializeComponent();
        }

        private void OnIncorrectDragOver(object sender, DragEventArgs e)
        {
            //e.AcceptedOperation = DataPackageOperation.None;
        }

        private async void OnCorrectDrop(object sender, DropEventArgs e)
        {
            _ = await e.Data.GetImageAsync();
            sourceImage.Source =null;
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            //image = (sender as Element).Parent as Image;
        }
    }
}