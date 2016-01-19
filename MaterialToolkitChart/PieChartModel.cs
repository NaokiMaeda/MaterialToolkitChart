using GalaSoft.MvvmLight;
using System;

namespace MaterialToolkitChart {
    class PieChartModel : ViewModelBase {
		private	String	_Name;
		public	String	Name {
			get {return	_Name;}
			set {
				if(_Name != value) {
					_Name = value;
                    RaisePropertyChanged(nameof(Name));
				}
			}
		}

		private	int	_Value;
		public	int	Value {
			get {return	_Value;}
			set {
				if(_Value != value) {
					_Value = value;
                    RaisePropertyChanged(nameof(Value));
				}
			}
		}
	}
}
