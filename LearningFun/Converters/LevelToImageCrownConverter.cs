using System;
using System.Globalization;
using Xamarin.Forms;

namespace LearningFun.Converters
{
    public class LevelToImageCrownConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string level = value as string;

            return level == string.Empty ? "crown_gray_stroke" : "crown_stroke";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
