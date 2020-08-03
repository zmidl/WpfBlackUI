using FanucTheme.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FanucTheme.Controls.ToggleButtons
{
   public class FanucToggleButton
   {
      public static OptionMarkPlace GetOptionMarkPlace(DependencyObject obj) => (OptionMarkPlace)obj.GetValue(OptionMarkPlaceProperty);
      public static void SetOptionMarkPlace(DependencyObject obj, OptionMarkPlace value) => obj.SetValue(OptionMarkPlaceProperty, value);
      public static readonly DependencyProperty OptionMarkPlaceProperty = DependencyProperty.RegisterAttached("OptionMarkPlace", typeof(OptionMarkPlace), typeof(FanucToggleButton), new PropertyMetadata(OptionMarkPlace.Left));

   }
}
