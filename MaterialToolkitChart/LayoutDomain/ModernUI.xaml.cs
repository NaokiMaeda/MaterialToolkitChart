using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace MaterialToolkitChart.LayoutDomain {
	/// <summary>
	/// ModernUI.xaml の相互作用ロジック
	/// </summary>
	public partial class ModernUI : UserControl {
		public ModernUI() {
			InitializeComponent();
			//var pieList = new ObservableCollection<PieData>();
			Queue<PieData>	pieList = new Queue<PieData>();
			pieList.Enqueue(new PieData());
			pieList.Enqueue(new PieData("JS" , 25));
			this.PieChart.ItemsSource = pieList;
		}
	}
}
