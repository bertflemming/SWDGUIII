using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TheDeptBook
{
    public class RegisteredDebitsViewModel : IPageViewModel
    {
        private SuperModel _superModel;

        public RegisteredDebitsViewModel(SuperModel superModel)
        {
            _superModel = superModel;
        }

        #region Properties

        private string _searchName;
        private double _value;
        private ObservableCollection<Transaction> _transactions;

        public string Name
        {
            get { return "Registered Debits Page"; }
        }

        public string SearchName
        {
            get { return _searchName; }
            set
            {
                if (_searchName != value)
                {
                    _searchName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ObservableCollection<Transaction> Transactions
        {
            get { return _transactions; }
            set
            {
                if (value != _transactions)
                {
                    _transactions = value;
                    NotifyPropertyChanged();
                }
            }
        }


        #endregion

        #region Commands

        ICommand _searchDebtorCommand;
        public ICommand SearchDebtorCommand
        {
            get { return _searchDebtorCommand ?? (_searchDebtorCommand = new RelayCommand(SearchDebtor, SearchDebtorCanExecute)); }
        }

        private void SearchDebtor()
        {
            Transactions = _superModel.SearchName(SearchName);
        }

        private bool SearchDebtorCanExecute()
        {
            return true;
        }

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
