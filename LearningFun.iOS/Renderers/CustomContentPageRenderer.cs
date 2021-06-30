using System;
using LearningFun.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ContentPage), typeof(CustomContentPageRenderer))]
namespace LearningFun.iOS.Renderers
{
    public class CustomContentPageRenderer : PageRenderer
    {
        public override bool PrefersStatusBarHidden()
        {
            return true;
        }
    }
}
