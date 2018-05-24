using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Patterns.Mediators;
using ToolBox.Patterns.MVVM.ViewModels;

namespace SwitchUserControl.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private object _CurrentView;

        public object CurrentView
        {
            get { return _CurrentView; }
            set { _CurrentView = value; RaisePropertyChanged(); }
        }
        public MainViewModel()
        {
            Mediator<object>.Instance.Register(ToSwitch);
            Mediator<object>.Instance.Send(new HomeViewModel());
        }

        private void ToSwitch(object obj)
        {
            CurrentView = obj;
        }
    }
}
