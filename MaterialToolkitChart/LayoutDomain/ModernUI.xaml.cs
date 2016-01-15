using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MaterialToolkitChart.LayoutDomain {
	/// <summary>
	/// ModernUI.xaml の相互作用ロジック
	/// </summary>
	public partial class ModernUI : UserControl{
        private List<PieData> pieList;
		public ModernUI() {
			InitializeComponent();
            pieList = new List<PieData>();
			pieList.Add(new PieData());
			pieList.Add(new PieData("JS" , 25));
			this.PieChart.ItemsSource = pieList;
            pieList.Add(new PieData("Python", 100));
            LoopChanger();
		}

        private async void LoopChanger() {
            while (true) {
                await Task.Delay(1000);
                pieList[2].value = DateTime.Now.Second;
            }
        }

    }
}
