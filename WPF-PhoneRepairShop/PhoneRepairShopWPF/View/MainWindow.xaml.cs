using WPFPhoneRepairShop.View;
using WPFPhoneRepairShop.ViewModel;
using System.Windows;


namespace WPFPhoneRepairShop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
