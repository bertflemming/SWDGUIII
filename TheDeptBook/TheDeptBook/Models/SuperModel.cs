using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TheDeptBook
{
    public class SuperModel
    {
        private ObservableCollection<DebtorModel> _allDebtors = new ObservableCollection<DebtorModel>();

        public SuperModel()
        {
        }

        public ObservableCollection<DebtorModel> Debtors
        {
            get { return _allDebtors; }
            set
            {
                if (_allDebtors != value)
                {
                    _allDebtors = value;
                }
            }
        }

        public double ShowDebt(string name)
        {
            DebtorModel tempDebtor = new DebtorModel();
            tempDebtor.DebtorName = name;
            if (_allDebtors.Count != 0)
            {
                foreach (var DebtorModel in _allDebtors)
                {
                    if (DebtorModel.DebtorName == tempDebtor.DebtorName)
                    {
                        return DebtorModel.TotalCredit;
                    }
                }
            }
            return 0;
        }

        public ObservableCollection<Transaction> SearchName(string findName)
        {
            DebtorModel tempDebtor = new DebtorModel();
            tempDebtor.DebtorName = findName;
            foreach (var debtorModel in _allDebtors)
            {
                if (debtorModel.DebtorName == tempDebtor.DebtorName)
                {
                    return debtorModel.Debits;
                }
            }
            return tempDebtor.Debits;
        }

        public void AddDebtor(string name, double initAmount)
        {
            DebtorModel tempDebtor = new DebtorModel();
            Transaction tempTransaction = new Transaction();

            tempDebtor.DebtorName = name;
            tempDebtor.TotalCredit = 0;
            tempDebtor.AddTransaction(DateTime.Now, initAmount);
            Debtors.Add(tempDebtor);
        }

        public ObservableCollection<DebtorModel> ShowDebtors()
        {
            return _allDebtors;
        }
    }


    public class Transaction
    {
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }


    public class DebtorModel
    {
        private ObservableCollection<Transaction> _debits = new ObservableCollection<Transaction>();

        private string _name;
        private double _totalCredit;


        public ObservableCollection<Transaction> Debits
        {
            get { return _debits; }
            set
            {
                if (_debits != value)
                {
                    _debits = value;
                }
            }
        }
        public string DebtorName
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
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
                }
            }
        }

        public DebtorModel()
        {
        }

        public DebtorModel(string name, double totalCredit)
        {
            DebtorName = name;
            TotalCredit = totalCredit;
        }

        public ObservableCollection<Transaction> ShowTransactions()
        {
            return _debits;
        }

        public void AddTransaction(DateTime date, double amount)
        {
            Transaction tempTransaction = new Transaction();
            tempTransaction.Date = date;
            tempTransaction.Amount = amount;
            _debits.Add(tempTransaction);
            TotalCredit = +amount;
        }
    }
}
