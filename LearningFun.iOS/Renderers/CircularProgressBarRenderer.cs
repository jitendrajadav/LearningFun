using LearningFun.Controls;
using LearningFun.iOS.Controls;
using LearningFun.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CircularProgressBar), typeof(CircularProgressBarRenderer))]
namespace LearningFun.iOS.Renderers
{
    public class CircularProgressBarRenderer : ViewRenderer<CircularProgressBar, CircularProgressBariOS>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control is null)
            {
                if (Element is null)
                    return;

                var nativeControl = new CircularProgressBariOS(
                    Element.WidthRequest,
                    Element.HeightRequest,
                    Element.TrackColor.ToCGColor(),
                    Element.ProgressColor.ToCGColor(),
                    Element.Progress
                );

                SetNativeControl(nativeControl);
            }
        }
    }
}
