using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace FanucTheme.Converters
{
   public class ConvertIsCheckedToPoint : IValueConverter
   {
      public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
      {
         var result = new Point(60, 60);
         switch ((bool?)value)
         {
            case true: { result.X = 120; break; }
            case false: { result.X = 60; break; }
            default: { result.X = 90; break; }
         }
         return result;
      }

      public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }
}
