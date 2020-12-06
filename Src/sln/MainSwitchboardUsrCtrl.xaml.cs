using AAV.WPF.Ext;
using AAV.WpfTheme.Model.App.Properties;
using System.Windows;
using System.Windows.Controls;

namespace AAV.WpfTheme.Model.App
{
  public partial class MainSwitchboardUsrCtrl : UserControl
  {
    public Window ContainerWindow => _owner ?? (_owner = this.FindParentWindow()); Window _owner;
    void popIt_modal(Window popWind, string lastWin) { ContainerWindow.Hide(); popWind.ShowDialog(); ContainerWindow.Show(); Settings.Default.LastWin = lastWin; }
    void popIt(Window popWind, string lastWin) { ContainerWindow.Hide(); popWind.Show(); ContainerWindow.Close(); Settings.Default.LastWin = lastWin; }

    public MainSwitchboardUsrCtrl() => InitializeComponent();

    void onA(object s, RoutedEventArgs e) => popIt(new HopWindowA(), "A");
    void onB(object s, RoutedEventArgs e) => popIt(new HopWindowB(), "B");
    void onC(object s, RoutedEventArgs e) => popIt(new HopWindowC(), "C");
  }
}
