using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Xaml.Interactivity;

namespace AvaloniaDialog.Behaviors
{
    public sealed class ShowDialogAction : AvaloniaObject, IAction
    {
        public static readonly StyledProperty<IDialog> DialogProperty = 
            AvaloniaProperty.Register<ShowDialogAction, IDialog>(nameof(Dialog));

        public IDialog Dialog
        {
            get => GetValue(DialogProperty);
            set => SetValue(DialogProperty, value);
        }

        public object? Execute(object? sender, object? parameter)
        {
            var window = new DialogWindow()
            {
                DataContext = Dialog
            };

            window.ShowDialog((Application.Current.ApplicationLifetime as IClassicDesktopStyleApplicationLifetime).MainWindow);

            return true;
        }
    }
}