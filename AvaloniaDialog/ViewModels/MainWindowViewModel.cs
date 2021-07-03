namespace AvaloniaDialog.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public SampleDialogViewModel SampleDialog { get; }

        public MainWindowViewModel()
        {
            SampleDialog = new SampleDialogViewModel()
            {
                Title = "Dialog"
            };
        }
    }
}