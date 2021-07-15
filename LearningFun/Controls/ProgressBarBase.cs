using System;
using Xamarin.Forms;

namespace LearningFun.Controls
{
    public abstract class ProgressBarBase : View
    {
        public static readonly BindableProperty TrackColorProperty =
            BindableProperty.Create(
                nameof(TrackColor),
                typeof(Color),
                typeof(ProgressBarBase),
                Color.Transparent
            );

        public Color TrackColor
        {
            get => (Color)GetValue(TrackColorProperty);
            set => SetValue(TrackColorProperty, value);
        }

        public static readonly BindableProperty ProgressColorProperty =
            BindableProperty.Create(
                nameof(ProgressColor),
                typeof(Color),
                typeof(ProgressBarBase),
                Color.Transparent
            );

        public Color ProgressColor
        {
            get => (Color)GetValue(ProgressColorProperty);
            set => SetValue(ProgressColorProperty, value);
        }

        public static readonly BindableProperty ProgressProperty =
            BindableProperty.Create(
                nameof(Progress),
                typeof(double),
                typeof(ProgressBarBase),
                0.0,
                BindingMode.TwoWay,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    ProgressBarBase control = (ProgressBarBase)bindable;
                    control.Progress = (double)newValue;
                }
            );

        public double Progress
        {
            get => (double)GetValue(ProgressProperty);
            set => SetValue(ProgressProperty, value);
        }

        public event EventHandler ValueChanged;
        public void NotifyValueChanged()
        {
            ValueChanged?.Invoke(this, new EventArgs());
        }
    }
}
