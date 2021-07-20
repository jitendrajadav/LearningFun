using System;
using System.Globalization;
using Xamarin.Forms;

namespace LearningFun.Converters
{
    public class AchievementsActiveToTextColorConverter : IValueConverter
    {
        private readonly Color _activeColor = Color.White;
        private readonly Color _finishedColor = Color.FromHex("#cc7700");

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value is bool isActive ? isActive ? _activeColor : (object)_finishedColor : _activeColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
