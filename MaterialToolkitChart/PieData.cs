using GalaSoft.MvvmLight;
using System;

namespace MaterialToolkitChart {
    class PieData :ViewModelBase{
		private	String _Key;
		public	String Key{
			get {return _Key;}
			set{
				_Key = value;
                RaisePropertyChanged(nameof(Key));
			}
		}

		private	int _Value;
		public	int	Value{
			get {return _Value;}
			set{
				_Value = value;
				RaisePropertyChanged(nameof(Value));
			}
		}

		public	PieData() {
			Key	= "Data0";
			Value	= 10;
		}

		public	PieData(String name , int value) {
			this.Key = name;
			this.Value = value;
		}
	}
}
