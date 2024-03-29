﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Flies.Wpf.Converters
{
    public class ObjectToVisibilityConverter : IValueConverter
    {
        public static ObjectToVisibilityConverter Instance { get; } = new ObjectToVisibilityConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null
                ? Visibility.Collapsed
                : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
