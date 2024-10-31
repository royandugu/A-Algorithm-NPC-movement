using Godot;
public partial class EzraChoiceButton:Button{
    private int choiceIndex=0;
    public int ChoiceIndex
    {
        get => choiceIndex;
        set => choiceIndex = value;
    }

    [Signal]
    public delegate void ChoiceSelectedEventHandler(int choiceSelected);
    public override void _Ready()
    {
        this.Pressed+=OnPressed;
    }

    public void OnPressed(){
        EmitSignal(nameof(ChoiceSelected),choiceIndex);
    }
}