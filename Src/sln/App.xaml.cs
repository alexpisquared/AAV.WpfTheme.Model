using AAV.Sys.Helpers;
using System;
using System.Diagnostics;
using System.Windows;

namespace AAV.WpfTheme.Model.App
{
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);

      ShutdownMode = ShutdownMode.OnLastWindowClose;

      //palyBeeps();

      new MainWindow().Show();

      Bpr.BeepBgn3();
    }
    protected override void OnExit(ExitEventArgs e) { base.OnExit(e); Bpr.BeepEnd3(); }
    protected override void OnSessionEnding(SessionEndingCancelEventArgs e) { base.OnSessionEnding(e); Bpr.BeepEnd3(); }

    static void palyBeeps()
    {
      if (!Debugger.IsAttached) return;

      while (true)
      {
        for (var i = 1; i < 30; i ++) { Debug.WriteLine(i); Bpr.Chime(i); }

        //for (int i = 5000; i < fh; i += 250) { Debug.WriteLine(i); Bpr.BeepFD(i, 250); }

        // Bpr.BeepFDA(pf, 111, 1000);
        //Bpr.BeepFDA(5100, 50, 1000);
        //Bpr.BeepFDA(5200, 150, 1000);
        //Bpr.BeepFDA(5000, 111, 1000);
        //Bpr.BeepEnD6(); Bpr.BeepEnd6(); Bpr.BeepEnd3();
      }
    }

  }
}
