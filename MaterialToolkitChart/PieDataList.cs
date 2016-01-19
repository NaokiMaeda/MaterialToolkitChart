using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MaterialToolkitChart {
	class PieDataList : INotifyPropertyChanged {
		private	String	_listName;
		public	String	listName {
			get {return	_listName;}
			set {
				if(_listName != null) {
					_listName = value;
					
				}
			}
		}

		public	List<PieData>	items {get;	set;}

		public	PieDataList() {
			items = new List<PieData>();
			items.Add(new PieData("Java" , 65));
			items.Add(new PieData("JavaScript" , 25));
			items.Add(new PieData("Python" , 10));
		}

		private void Changer() {

		}

		public event PropertyChangedEventHandler PropertyChanged;
		private	void NotifyPropertyChange([CallerMemberName] String PropertyName = null) {
			PropertyChanged?.Invoke(this , new PropertyChangedEventArgs(PropertyName));
		}
	}
}
