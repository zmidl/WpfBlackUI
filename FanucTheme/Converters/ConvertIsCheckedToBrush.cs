using FanucTheme.Themes.Styles;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace FanucTheme.Converters
{
   public class ConvertIsCheckedToBrush : IValueConverter
   {
      private SolidColorBrush result = new SolidColorBrush();
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         Color NullcheckedColor = (Color)Common.ResourceDictionary[nameof(NullcheckedColor)];
         Color Wasp = (Color)Common.ResourceDictionary[nameof(Wasp)];
         Color UncheckedColor = (Color)Common.ResourceDictionary[nameof(UncheckedColor)];
         if (parameter == null) parameter = false;
         if (bool.TryParse(parameter?.ToString(), out bool isBrush))
         {
            switch ((bool?)value)
            {
               case true:
                  {
                     if (isBrush) return new SolidColorBrush(Wasp);
                     else return Wasp;
                  }
               case false:
                  {
                     if (isBrush) return new SolidColorBrush(UncheckedColor);
                     else return UncheckedColor;
                  }
               default:
                  {
                     if (isBrush) return new SolidColorBrush(NullcheckedColor);
                     else return NullcheckedColor;
                  }
            }
         }
         else return null;
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}
