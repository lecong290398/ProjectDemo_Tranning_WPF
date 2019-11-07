﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DemoPrsim_Login.Converters
{
    class VisibilityConverter : IValueConverter
    {
        public const string Invert = "Invert";
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool visibility = false;
            if (value is bool)
            {
                visibility = (bool)value;
            }
            return visibility ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            Visibility visibility = (Visibility)value;
            return (visibility == Visibility.Visible);
        }
    }
}
