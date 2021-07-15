using Android.Content;
using LearningFun.Controls;
using LearningFun.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomProgressBar), typeof(CustomProgressBarRenderer))]
namespace LearningFun.Droid.Renderers
{
    public class CustomProgressBarRenderer : ProgressBarRenderer
    {
        public CustomProgressBarRenderer(Context context) : base(context)
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ProgressBar> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                var progressBar = Control;
                var draw = Context.GetDrawable(Resource.Drawable.bar_color);
                progressBar.ProgressDrawable = draw;
            }
        }
    }
}