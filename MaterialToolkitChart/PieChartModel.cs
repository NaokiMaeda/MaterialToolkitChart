using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MaterialToolkitChart {
	class PieChartModel : INotifyPropertyChanged {
		private	String	_Name;
		public	String	Name {
			get {return	_Name;}
			set {
				if(_Name != value) {
					_Name = value;
					NotifyPropertyChange("Name");
				}
			}
		}

		private	int	_Value;
		public	int	Value {
			get {return	_Value;}
			set {
				if(_Value != value) {
					_Value = value;
					NotifyPropertyChange("Value");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private	void NotifyPropertyChange([CallerMemberName]String propertyName = null) {
			PropertyChanged?.Invoke(this , new PropertyChangedEventArgs(propertyName));
		}
	}
}
