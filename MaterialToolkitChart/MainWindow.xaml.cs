using System.Windows;
using System.Collections.Generic;
using System;
using System.Windows.Input;

namespace MaterialToolkitChart {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window{
        public MainWindow(){
            InitializeComponent();

            Queue<Data> list = new Queue<Data>();
            list.Enqueue(new Data());
            list.Enqueue(new Data(200, 2017));
        }

		private void UIElement_OnPreviewMouseButtonUp(object sender, MouseButtonEventArgs e) {
			MenuToggleButton.IsChecked = false;
		}
	}
}
