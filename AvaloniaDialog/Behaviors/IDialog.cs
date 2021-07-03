namespace AvaloniaDialog.Behaviors
{
    public interface IDialog
    {
        string Title { get; set; }
        void SetResult(object result);
    }
}