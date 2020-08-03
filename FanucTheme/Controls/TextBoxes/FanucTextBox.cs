using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FanucTheme.Controls.TextBoxes
{
   public class FanucTextBox
   {
      public static Geometry GetData(DependencyObject obj) => (Geometry)obj.GetValue(DataProperty);
      public static void SetData(DependencyObject obj, Geometry value) => obj.SetValue(DataProperty, value);
      public static readonly DependencyProperty DataProperty = DependencyProperty.RegisterAttached("Data", typeof(Geometry), typeof(FanucTextBox), new PropertyMetadata(null));


      public static Brush GetLogoColor(DependencyObject obj) => (Brush)obj.GetValue(LogoColorProperty);
      public static void SetLogoColor(DependencyObject obj, Brush value) => obj.SetValue(LogoColorProperty, value);
      public static readonly DependencyProperty LogoColorProperty = DependencyProperty.RegisterAttached("LogoColor", typeof(Brush), typeof(FanucTextBox), new PropertyMetadata(Brushes.DarkGray));


      public static CornerRadius GetRadius(DependencyObject obj) => (CornerRadius)obj.GetValue(RadiusProperty);
      public static void SetRadius(DependencyObject obj, CornerRadius value) => obj.SetValue(RadiusProperty, value);
      public static readonly DependencyProperty RadiusProperty = DependencyProperty.RegisterAttached("Radius", typeof(CornerRadius), typeof(FanucTextBox), new PropertyMetadata(new CornerRadius(0)));

   }
}
