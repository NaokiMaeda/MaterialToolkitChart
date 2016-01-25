using System;
using System.Windows;

namespace MaterialToolkitChart {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window{
        public MainWindow(){
			InitializeComponent();
            PieDataList list = new PieDataList();
            list.listName = "DataList100";
            this.PieChart.SeriesTitle = list.listName;
            this.PieChart.ItemsSource = list.items;
            Console.WriteLine(PieChart.SeriesTitle);
            Console.WriteLine(PieChart.HasItems);
        }
    }
}
