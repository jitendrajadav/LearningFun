using CoreGraphics;
using LearningFun.Controls;
using LearningFun.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomProgressBar), typeof(CustomProgressBarRenderer))]
namespace LearningFun.iOS.Renderers
{
    public class CustomProgressBarRenderer : ProgressBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);
            Control.ProgressTintColor = Color.FromRgb(255, 201, 74).ToUIColor();
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            var X = 1.0f;
            var Y = 7.0f;
            CGAffineTransform transform = CGAffineTransform.MakeScale(X, Y);
            Transform = transform;
            ClipsToBounds = true;
            Layer.MasksToBounds = true;
            Layer.CornerRadius = 5; // This is for rounded corners.
        }
    }
}