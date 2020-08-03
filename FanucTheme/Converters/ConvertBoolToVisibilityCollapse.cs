﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace FanucTheme.Converters
{
   public class ConvertBoolToVisibilityCollapse : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         return System.Convert.ToBoolean(value) ? Visibility.Visible : Visibility.Collapsed;
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}
