using Assignment5.Forms;

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
