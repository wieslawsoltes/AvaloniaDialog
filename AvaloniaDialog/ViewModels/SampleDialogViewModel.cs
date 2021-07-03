using AvaloniaDialog.Behaviors;
using ReactiveUI;

namespace AvaloniaDialog.ViewModels
{
    public class SampleDialogViewModel : ViewModelBase, IDialog
    {
        private string? _title;
        private object? _result;

        public object? Result
        {
            get => _result;
            set => this.RaiseAndSetIfChanged(ref _result, value);
        }

        public string? Title
        {
            get => _title;
            set => this.RaiseAndSetIfChanged(ref _title, value);
        }

        public void SetResult(object? result)
        {
            Result = result;
        }
    }
}