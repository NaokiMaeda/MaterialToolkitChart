using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MaterialToolkitChart
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window{
		private List<PieData>	PieList;
        public MainWindow(){
			InitializeComponent();
			PieList = new List<PieData>();
			PieList.Add(new PieData("Java" , 65));
			PieList.Add(new PieData("JavaScript" , 25));
			
			this.PieChart.ItemsSource = PieList;
			PieList.Add(new PieData("Python", 10));
			Looper();
        }

		private async void Looper() {
			while(true) {
				await Task.Delay(1000);
				PieList[2].Value = DateTime.Now.Second;
				Console.WriteLine(PieList[2].Value);
			}
		}
    }
}
