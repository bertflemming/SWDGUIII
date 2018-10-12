using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace TheDeptBook
{
    public class MainViewModel : INotifyPropertyChanged, IPageViewModel
    {
        private SuperModel _superModel;

        public MainViewModel(SuperModel superModel)
        {
            _superModel = superModel;
        }

        #region Properties

        public string Name
        {
            get { return "Main Page"; }
        }

        public ObservableCollection<DebtorModel> Debtors
        {
            get { return _superModel.Debtors; }
            set
            {
                if (value != _superModel.Debtors)
                {
                    _superModel.Debtors = value;
                    NotifyPropertyChanged();
                }
            }
        }


        #endregion

        #region Commands


        #endregion

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
