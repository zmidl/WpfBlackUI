using FanucTheme.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FanucTheme.Controls.CheckBoxes
{
   public class FanucCheckBox
   {
      public static CornerRadius GetRadius(DependencyObject obj) => (CornerRadius)obj.GetValue(RadiusProperty);
      public static void SetRadius(DependencyObject obj, CornerRadius value) => obj.SetValue(RadiusProperty, value);
      public static readonly DependencyProperty RadiusProperty = DependencyProperty.RegisterAttached("Radius", typeof(CornerRadius), typeof(FanucCheckBox), new PropertyMetadata(new CornerRadius(0)));

      public static OptionMarkPlace GetOptionMarkPlace(DependencyObject obj)=> (OptionMarkPlace)obj.GetValue(OptionMarkPlaceProperty);
      public static void SetOptionMarkPlace(DependencyObject obj, OptionMarkPlace value)=>obj.SetValue(OptionMarkPlaceProperty, value);
      public static readonly DependencyProperty OptionMarkPlaceProperty = DependencyProperty.RegisterAttached("OptionMarkPlace", typeof(OptionMarkPlace), typeof(FanucCheckBox), new PropertyMetadata(OptionMarkPlace.Left));
   }
}
