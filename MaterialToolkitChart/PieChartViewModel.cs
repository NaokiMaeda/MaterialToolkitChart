using GalaSoft.MvvmLight;

namespace MaterialToolkitChart {
    class PieChartViewModel : ViewModelBase{
		private	PieChartModel	_pieChartModel;
		public	PieChartModel	pieChartModel{
			get {return	_pieChartModel;}
			set {
				if(_pieChartModel != value) {
					_pieChartModel = value;
                    RaisePropertyChanged(nameof(pieChartModel));
				}
			}
		}
		public	PieChartViewModel() {
			pieChartModel = new PieChartModel();
		}
	}
}
