using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MaterialToolkitChart.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase{
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>

        private PieDataList _list;
        public  PieDataList list {
            get { return _list; }
            set {
                if (_list != value) {
                    _list = value;
                    RaisePropertyChanged(nameof(list));
                }
            }
        }

        public RelayCommand SwitchSeries {
            get;
            private set;
        }

        private bool _seriesSwitched;
        public bool seriesSwitched {
            get {
                return _seriesSwitched;
            }
            set {
                if (_seriesSwitched != value) {
                    _seriesSwitched = value;
                    RaisePropertyChanged(nameof(seriesSwitched));
                }
            }
        }

        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            SwitchSeries = new RelayCommand(() => switchSeries());
            seriesSwitched = false;

            list = new PieDataList();
            list.listName = "Data21";
            list.items.Add(new PieData("mk.1", 10));
            list.items.Add(new PieData("mk.2", 11));
            list.items.Add(new PieData("mk.3", 15));
            list.items.Add(new PieData("mk.4", 20));
            list.items.Add(new PieData("mk.5", 26));
            list.items.Add(new PieData("mk.6", 16));
        }

        private void switchSeries() {
            seriesSwitched = !seriesSwitched;
        }
    }
}