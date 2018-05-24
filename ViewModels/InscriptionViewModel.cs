using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ToolBox.Patterns.MVVM.Commands;
using ToolBox.Patterns.MVVM.ViewModels;

namespace SwitchUserControl.ViewModels
{
    public class InscriptionViewModel : ViewModelBase
    {
        private string _Pseudo;

        public string Pseudo
        {
            get { return _Pseudo; }
            set { _Pseudo = value; RaisePropertyChanged(); }
        }
        private string _Password;

        private string _PasswordChar;

        public string PasswordChar
        {
            get
            {
                string szChar = "";

                foreach (char szCahr in _Password)
                {
                    szChar = szChar + "*";
                }

                return szChar;
            }

            set
            {
                _PasswordChar = value; RaisePropertyChanged();
            }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value;
                PasswordChar = _Password;
            RaisePropertyChanged(); }
        }
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private ICommand _ValiderInscription;
        public ICommand ValiderInscription
        {
            get { return _ValiderInscription ?? (_ValiderInscription = new RelayCommand(ValiderExec,ValiderCanExec)); }
        }

        private void ValiderExec()
        {
            MessageBox.Show(PasswordChar);
        }

        private bool ValiderCanExec()
        {
           if(!string.IsNullOrWhiteSpace(Password) && !string.IsNullOrWhiteSpace(Pseudo))
           {
                return true;
           }
            else
            {
                return false;
            }
        }
    }
}
