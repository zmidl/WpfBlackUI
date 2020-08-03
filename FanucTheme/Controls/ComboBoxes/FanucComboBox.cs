using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FanucTheme.Controls.ComboBoxes
{
   public class FanucComboBox
   {
      public static CornerRadius GetRadius(DependencyObject obj) => (CornerRadius)obj.GetValue(RadiusProperty);
      public static void SetRadius(DependencyObject obj, CornerRadius value) => obj.SetValue(RadiusProperty, value);
      public static readonly DependencyProperty RadiusProperty = DependencyProperty.RegisterAttached("Radius", typeof(CornerRadius), typeof(FanucComboBox), new PropertyMetadata(new CornerRadius(0)));



      public static CornerRadius GetItemRadius(DependencyObject obj)=> (CornerRadius)obj.GetValue(ItemRadiusProperty);
      public static void SetItemRadius(DependencyObject obj, CornerRadius value)=>obj.SetValue(ItemRadiusProperty, value);
      public static readonly DependencyProperty ItemRadiusProperty =  DependencyProperty.RegisterAttached("ItemRadius", typeof(CornerRadius), typeof(FanucComboBox), new PropertyMetadata(new CornerRadius(5)));



      public static System.Windows.Media.Brush GetItemForeground(DependencyObject obj)
      {
         return (System.Windows.Media.Brush)obj.GetValue(ItemForegroundProperty);
      }

      public static void SetItemForeground(DependencyObject obj, System.Windows.Media.Brush value)
      {
         obj.SetValue(ItemForegroundProperty, value);
      }

      // Using a DependencyProperty as the backing store for ItemForeground.  This enables animation, styling, binding, etc...
      public static readonly DependencyProperty ItemForegroundProperty =
          DependencyProperty.RegisterAttached("ItemForeground", typeof(System.Windows.Media.Brush), typeof(FanucComboBox), new PropertyMetadata(System.Windows.Media.Brushes.White));


   }
}
