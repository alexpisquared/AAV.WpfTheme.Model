using AAV.Sys.Helpers;
using Expression.Blend.SampleData.SampleDataSource;
using System.Collections.Generic;
using System.ComponentModel;
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
      dg1.ItemsSource = new List<Row>(); for (var i = 1; i <= 7; i++) ((List<Row>)dg1.ItemsSource).Add(new Row { ID = i * 10, Name = $"{(char)(i + 64)}{(char)(i + 97)}{(char)(i + 98)} {(char)(i + 99)}{(char)(i + 100)}{(char)(i + 101)}" });

      var sdl = new Expression.Blend.SampleData.SampleDataSource.SampleList();
      dg2.ItemsSource = sdl;
      lb2.ItemsSource = sdl;

      var sds = new SampleDataSource(); ;
      DataContext = sds;
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
namespace Cities.Models
{
  public class City
  {
    public string Name { get; set; }
    public string Country { get; set; }
  }
  public class SampleListItem : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
      {
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
    }

    double _ID = 0; public double ID
    {
      get => _ID;

      set
      {
        if (_ID != value)
        {
          _ID = value;
          OnPropertyChanged("ID");
        }
      }
    }
    string _Name = string.Empty; public string Name
    {
      get => _Name;

      set
      {
        if (_Name != value)
        {
          _Name = value;
          OnPropertyChanged("Name");
        }
      }
    }
    System.Windows.Media.ImageSource _Look = null; public System.Windows.Media.ImageSource Look
    {
      get => _Look;

      set
      {
        if (_Look != value)
        {
          _Look = value;
          OnPropertyChanged("Look");
        }
      }
    }
    bool _Done = false; public bool Done
    {
      get => _Done;

      set
      {
        if (_Done != value)
        {
          _Done = value;
          OnPropertyChanged("Done");
        }
      }
    }
  }
}