using ReactiveUI;
using System.Reactive;

namespace Email.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ReactiveCommand<Unit, Unit> SendMail { get; }
        public ViewModelBase Content 
        { 
            get => _content;
            set => this.RaiseAndSetIfChanged(ref _content, value);
         }

        private ViewModelBase _content;

        public MainWindowViewModel()
        {
            SendMail = ReactiveCommand.Create(Send);
            Content = new SendViewModel();
        }
        
        private void Send()
        {
        }
    }
}
