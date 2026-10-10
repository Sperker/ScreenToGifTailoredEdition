using ScreenToGif.Util;
using System;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace ScreenToGif.Views.Settings;

public partial class AboutSettings : Page
{
    public AboutSettings()
    {
        InitializeComponent();
    }

    private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        e.Handled = true;

        try
        {
            ProcessHelper.StartWithShell(e.Uri.AbsoluteUri);
        }
        catch (Exception ex)
        {
            LogWriter.Log(ex, "Open Hyperlink");
        }
    }
}