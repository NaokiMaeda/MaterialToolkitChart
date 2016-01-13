using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MaterialToolkitChart {
	class PieData : INotifyPropertyChanged {
		private	String	_name;
		private	int		_value;

		public String name{
			get {return _name;}
			set{
				_name = value;
				NotifyPropertyChanged("name");
			}
		}

		public int value{
			get {return _value;}
			set{
				_value = value;
				NotifyPropertyChanged("value");
			}
		}

		public PieData() {
			name = "DataA";
			value = 35;
		}

		public PieData(String name , int value) {
			this.name = name;
			this.value = value;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void NotifyPropertyChanged([CallerMemberName] String propertyName = "") {
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
