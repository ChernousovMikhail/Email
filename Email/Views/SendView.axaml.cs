using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Email.Views
{
    public partial class SendView : UserControl
    {
        public SendView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
