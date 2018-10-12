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
    public class AddDeptorViewModel : INotifyPropertyChanged, IPageViewModel
    {
        private SuperModel _superModel;

        public AddDeptorViewModel(SuperModel superModel)
        {
            _superModel = superModel;
        }

        #region Properties

        private string _debtorName;
        private double _totalCredit;

        public string Name
        {
            get { return "Add Deptor Page"; }
        }

        public string DebtorName
        {
            get { return _debtorName; }
            set
            {
                if (_debtorName != value)
                {
                    _debtorName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public double TotalCredit
        {
            get { return _totalCredit; }
            set
            {
                if (_totalCredit != value)
                {
                    _totalCredit = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Commands

        ICommand _saveDebtorCommand;
        public ICommand SaveDebtorCommand
        {
            get { return _saveDebtorCommand ?? (_saveDebtorCommand = new RelayCommand(SaveDebtor, SaveDebtorCanExecute)); }
        }

        private void SaveDebtor()
        {
            _superModel.AddDebtor(DebtorName, TotalCredit);
        }

        private bool SaveDebtorCanExecute()
        {
            if (Name != "" && TotalCredit != 0)
                return true;
            else
                return false;
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
