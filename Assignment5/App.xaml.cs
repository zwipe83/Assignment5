using Assignment5.Forms;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Assignment5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private readonly FormMain formMain = new();
        public App()
        {
            formMain.Show();
        }
    }
}
