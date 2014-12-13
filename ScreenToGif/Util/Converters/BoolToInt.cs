﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ScreenToGif.Util.Converters
{
    public class BoolToInt : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var integer = value as int?;

            if (!integer.HasValue)
                return DependencyProperty.UnsetValue;

            return integer == int.Parse(parameter.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var parameterString = parameter as string;

            if (parameterString == null || value.Equals(false)) 
                return DependencyProperty.UnsetValue;

            return parameter;
        }
    }
}
