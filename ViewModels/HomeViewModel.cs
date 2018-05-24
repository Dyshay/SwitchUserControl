using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Patterns.Mediators;
using ToolBox.Patterns.MVVM.Commands;

namespace SwitchUserControl.ViewModels
{
    public class HomeViewModel
    {
        private ICommand _InscriptionBouton;
        public ICommand InscriptionBouton
        {
            get { return _InscriptionBouton ?? (_InscriptionBouton = new RelayCommand(InscriptionExec));}
        }
        private ICommand _ConnexionBouton;
        public ICommand ConnexionBouton
        {
            get { return _ConnexionBouton ?? (_ConnexionBouton = new RelayCommand(ConnexionExec)); }
        }
        private void InscriptionExec()
        {
            Mediator<object>.Instance.Send(new InscriptionViewModel());
        }
        private void ConnexionExec()
        {
            Mediator<object>.Instance.Send(new LoginViewModel());
        }
    }
}
