﻿using System;
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

namespace MaterialToolkitChart.LayoutDomain {
	/// <summary>
	/// UserControl1.xaml の相互作用ロジック
	/// </summary>
	public partial class Home : UserControl {
		public Home() {
			InitializeComponent();
			Queue<Data> list = new Queue<Data>();
			list.Enqueue(new Data());
			list.Enqueue(new Data(200, 2017));
			this.DataView.ItemsSource = list;
		}
	}
}
