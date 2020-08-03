using System.Windows;
using System.Windows.Media;

namespace FanucTheme.Controls.PasswordBox
{
   public class FanucPasswordBox
   {
      public static Geometry GetData(DependencyObject obj) => (Geometry)obj.GetValue(DataProperty);
      public static void SetData(DependencyObject obj, Geometry value) => obj.SetValue(DataProperty, value);
      public static readonly DependencyProperty DataProperty = DependencyProperty.RegisterAttached("Data", typeof(Geometry), typeof(FanucPasswordBox), new PropertyMetadata(null));


      public static Brush GetLogoColor(DependencyObject obj)=>(Brush)obj.GetValue(LogoColorProperty);
      public static void SetLogoColor(DependencyObject obj, Brush value)=>obj.SetValue(LogoColorProperty, value);
      public static readonly DependencyProperty LogoColorProperty = DependencyProperty.RegisterAttached("LogoColor", typeof(Brush), typeof(FanucPasswordBox), new PropertyMetadata(Brushes.DarkGray));


   }
}
