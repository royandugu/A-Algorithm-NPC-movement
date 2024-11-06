public partial class DialogResponse
{
    private string text;
    private string[] choice;

    public string Text
    {
        get => text;
        set => text = value;
    }
    public string[] Choice
    {
        get => choice;
        set => choice = value;
    }
}