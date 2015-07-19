using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SpikeSilverlightApplication
{
    public partial class MainPage : UserControl
    {
        string startupPath = string.Empty;
        public MainPage()
        {
            InitializeComponent();
            startupPath = App.Current.Host.Source.Scheme + @"://" +
                          App.Current.Host.Source.Host + ":" +
                          App.Current.Host.Source.Port.ToString() + @"/SL_Window_MultiBrowserSupportTestPage.aspx";
        }

        private void tabBTn_Click(object sender, RoutedEventArgs e)
        {
            tabBTn.TargetName = "_blank";
            string url = startupPath + "#ChildPage.xaml";
            tabBTn.NavigateUri = new Uri(url, UriKind.RelativeOrAbsolute);
        }

        private void browserBtn_Click(object sender, RoutedEventArgs e)
        {
            HtmlPopupWindowOptions options = new HtmlPopupWindowOptions();
            options.Left = 300;
            options.Top = 150;
            options.Width = 1024;
            options.Height = 768;
            options.Directories = false;
            options.Location = false;
            options.Menubar = false;
            options.Status = false;
            options.Toolbar = false;

            Uri myUri = new Uri(startupPath + "#ChildPage.xaml");
            HtmlPage.PopupWindow(myUri, "self", options);
        }
    }
}
