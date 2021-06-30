﻿using System;
using LearningFun.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ImageButton), typeof(CustomImageButtonRenderer))]
namespace LearningFun.iOS.Renderers
{
    public class CustomImageButtonRenderer : ImageButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ImageButton> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.AdjustsImageWhenHighlighted = false;
            }
        }

        protected override UIButton CreateNativeControl()
        {
            return new UIButton(UIButtonType.Custom);
        }
    }
}
