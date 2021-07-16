
using Xamarin.Forms;

namespace LearningFun.Views
{
    public partial class DragAndDropGesture : ContentPage
    {
        Image image = null;
        public DragAndDropGesture()
        {
            InitializeComponent();
        }

        private void OnIncorrectDragOver(object sender, DragEventArgs e)
        {
            //e.AcceptedOperation = DataPackageOperation.None;
            //e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private async void OnCorrectDrop(object sender, DropEventArgs e)
        {
           var image = await e.Data.GetImageAsync();
            sourceImage.Source =null;
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            
            //image = (sender as Element).Parent as Image;
        }
    }
}