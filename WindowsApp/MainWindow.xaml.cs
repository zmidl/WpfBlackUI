using FanucTheme.Controls.Buttons;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsApp
{
   /// <summary>
   /// MainWindow.xaml 的交互逻辑
   /// </summary>
   public partial class MainWindow : Window
   {
      private bool hasDefaultSkin = false;

      public List<MyDataSource> MyDataSources { get; set; } = new List<MyDataSource>();

      public MainWindow()
      {
         InitializeComponent();
         this.DataContext = this;
         for (int i = 0; i < 10; i++) this.MyDataSources.Add(new MyDataSource(i + 1, $"Name{i * 2}", i + 30));
      }

      ResourceDictionary currentLanguageResource;


      private void ChangeSkin(string skinName = null)
      {
         var skinPath = $"pack://application:,,,/FanucTheme;component/Themes/Skins/Default.xaml";
         if (string.IsNullOrEmpty(skinName) == false) skinPath = $"{Environment.CurrentDirectory}\\Assets\\Themes\\{skinName}.xaml";
         if (currentLanguageResource != null) App.Current.Resources.MergedDictionaries.Remove(currentLanguageResource);
         currentLanguageResource = new ResourceDictionary { Source = new Uri(skinPath) };
         if (currentLanguageResource != null) App.Current.Resources.MergedDictionaries.Add(currentLanguageResource);
      }

      private IEnumerable<string> GetThemes(string directory)
      {
         foreach (var item in Directory.GetFiles(directory, "*xaml")) yield return new FileInfo(item).Name.Split('.')[0];
      }

      private readonly string selectedItem = string.Empty;
      private void ComboBox_DropDownOpened(object sender, EventArgs e)
      {
         var comboBox = sender as ComboBox;
         var skins = this.GetThemes($"{Environment.CurrentDirectory}\\Assets\\Themes").ToList();

         if (skins.Contains("Default")) this.hasDefaultSkin = true;
         else
         {
            skins.Add("Default");
            this.hasDefaultSkin = false;
         }
         comboBox.ItemsSource = skins;
      }

      private void ComboBox_DropDownClosed(object sender, EventArgs e)
      {
         var skin = (sender as ComboBox).SelectedValue?.ToString();
         if (skin != null)
         {
            if (skin == "Default" && this.hasDefaultSkin == false) skin = null;
            this.ChangeSkin(skin);
         }
      }

      bool aa;
      private void Button_Click(object sender, RoutedEventArgs e)
      {
         var button = sender as System.Windows.Controls.Button;
         button.SetIsLoading(aa = !aa);
      }
   }

   public class MyDataSource
   {
      public int Id { get; set; }

      public int Age { get; set; }

      public string Name { get; set; }

      public MyDataSource() => Age = 0;

      public MyDataSource(int id, string name, int age)
      {
         this.Id = id;
         this.Name = name;
         this.Age = age;
      }
   }

   public class AgeRangeRule : ValidationRule
   {
      private int _min;
      private int _max;

      public AgeRangeRule()
      {
      }

      public int Min
      {
         get { return _min; }
         set { _min = value; }
      }

      public int Max
      {
         get { return _max; }
         set { _max = value; }
      }

      public override ValidationResult Validate(object value, CultureInfo cultureInfo)
      {
         int age = 0;

         try
         {
            if (((string)value).Length > 0)
               age = Int32.Parse((String)value);
         }
         catch (Exception e)
         {
            return new ValidationResult(false, "Illegal characters or " + e.Message);
         }

         if ((age < Min) || (age > Max))
         {
            return new ValidationResult(false,
              "Please enter an age in the range: " + Min + " - " + Max + ".");
         }
         else
         {
            return new ValidationResult(true, null);
         }
      }
   }
}
