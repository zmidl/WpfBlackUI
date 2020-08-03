using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FanucTheme.Themes.Styles
{
   public static class Common
   {
      public static ResourceDictionary ResourceDictionary=> new ResourceDictionary { Source = new Uri("pack://application:,,,/FanucTheme;component/Themes/Skins/Default.xaml") };
   }
}
