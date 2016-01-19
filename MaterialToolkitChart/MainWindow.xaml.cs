using System.Windows;

namespace MaterialToolkitChart {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window{
        public MainWindow(){
			InitializeComponent();
			PieChartViewModel model = new PieChartViewModel();
        }
    }
}
