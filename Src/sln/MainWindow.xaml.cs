using AAV.Sys.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace AAV.WpfTheme.Model.App
{
  public partial class MainWindow : WPF.Base.WindowBase
  {
    public MainWindow()
    {
      InitializeComponent();
      Bpr.Beep1of2();

      themeSelector1.ApplyTheme = ApplyTheme;
    }
    async void onLoaded(object s, RoutedEventArgs e)
    {
      Bpr.Beep2of2();
      tbkInfo.Text = $"{OneDrive.Root}";
      await Task.Yield();

      populateDemoData();
      themeSelector1.SetCurTheme(Thm);
    }

    void populateDemoData()
    {
      dg1.ItemsSource = new List<Row>();
      for (var i = 1; i <= 7; i++)
        ((List<Row>)dg1.ItemsSource).Add(new Row { ID = i * 10, Name = $"{(char)(i + 64)}{(char)(i + 97)}{(char)(i + 98)} {(char)(i + 99)}{(char)(i + 100)}{(char)(i + 101)}" });
    }

    void onDefaultClick(object s, RoutedEventArgs e) => MessageBox.Show("Nothing assigned to this event.");
    void onAccessKeyPressed_focusT2(object sender, System.Windows.Input.AccessKeyPressedEventArgs e) => t2.Focus();

    class Row
    {
      public int ID { get; set; }
      public string Name { get; set; }
    }

  }
}
