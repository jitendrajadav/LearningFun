
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
            e.AcceptedOperation = DataPackageOperation.None;
        }

        private void OnCorrectDrop(object sender, DropEventArgs e)
        {

        }
    }
}