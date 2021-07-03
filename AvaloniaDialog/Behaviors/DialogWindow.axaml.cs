using System.ComponentModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaDialog.Behaviors
{
    public class DialogWindow : Window
    {
        public DialogWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void Ok_OnClick(object? sender, RoutedEventArgs e)
        {
            if (DataContext is IDialog dialog)
            {
                dialog.SetResult(true);
                Close();
            }
        }

        private void Cancel_OnClick(object? sender, RoutedEventArgs e)
        {
            if (DataContext is IDialog dialog)
            {
                dialog.SetResult(false);
                Close();
            }
        }
    }
}