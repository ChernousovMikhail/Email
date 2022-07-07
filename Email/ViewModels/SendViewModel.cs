using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Email.ViewModels
{
    public class SendViewModel : ViewModelBase
    {       
        public ICommand SendCommand => ReactiveCommand.Create(SendEmail);

        public string To { get => _to; set => this.RaiseAndSetIfChanged(ref _to, value); }

        private string _to;

        public void SendEmail()
        {
        }
    }
}
