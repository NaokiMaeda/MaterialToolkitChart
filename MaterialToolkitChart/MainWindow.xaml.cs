using System.Windows;
using System.Collections.Generic;
namespace MaterialToolkitChart {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(){
            InitializeComponent();

            Queue<Data> list = new Queue<Data>();
            list.Enqueue(new Data());
            list.Enqueue(new Data(200, 2017));
            this.DataView.ItemsSource = list;

        }
    }
}
