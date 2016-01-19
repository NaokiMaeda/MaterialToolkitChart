using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MaterialToolkitChart {
	class PieChartViewModel : INotifyPropertyChanged {
		private	PieChartModel	_pieChartModel;
		public	PieChartModel	pieChartModel{
			get {return	_pieChartModel;}
			set {
				if(_pieChartModel != value) {
					_pieChartModel = value;
					NotifyPropertyChange("pieChartModel");
				}
			}
		}
		public	PieChartViewModel() {
			pieChartModel = new PieChartModel();
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public	void NotifyPropertyChange([CallerMemberName]String propertyName = null) {
			PropertyChanged?.Invoke(this , new PropertyChangedEventArgs(propertyName));
		}
	}
}
