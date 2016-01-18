using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaterialToolkitChart {
	class PieData : INotifyPropertyChanged{
		private	String _Key;
		public	String Key{
			get {return _Key;}
			set{
				_Key = value;
				NotifyPropertyChanged("Key");
			}
		}

		private	int _Value;
		public	int	Value{
			get {return _Value;}
			set{
				_Value = value;
				NotifyPropertyChanged("Value");
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

		public event PropertyChangedEventHandler PropertyChanged;
		private void NotifyPropertyChanged([CallerMemberName] String propertyName="") {
			if(PropertyChanged != null) {
				PropertyChanged(this , new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
