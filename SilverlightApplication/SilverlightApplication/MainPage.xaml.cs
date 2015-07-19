using System;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;

namespace SilverlightApplication
{
    public partial class MainPage : UserControl
    {
        string startupPath = string.Empty;

        public MainPage()
        {
            InitializeComponent();
            startupPath = App.Current.Host.Source.Scheme + @"://" +
                          App.Current.Host.Source.Host + ":" +
                          App.Current.Host.Source.Port + @"/MultiTabSilverlightApplicationTestPage.aspx";
        }

        private void Button_Save(object sender, System.Windows.RoutedEventArgs e)
        {
//            var data = NameBox.Text +" "+ AgeBox.Text;
//            MessageBox.Show(data);
            
//            HtmlPage.Window.Navigate();

            btn.TargetName = "_blank";
            string url = startupPath + "#ChildWindow.xaml";
            btn.NavigateUri = new Uri(url, UriKind.RelativeOrAbsolute);
        }
    }
}
