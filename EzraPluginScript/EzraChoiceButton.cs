using Godot;
public partial class EzraChoiceButton:Button{
    private int choiceIndex=0;
    public int ChoiceIndex
    {
        get => choiceIndex;
        set => choiceIndex = value;
    }
    public override void _Ready()
    {
        this.Pressed+=OnPressed;
    }

    public override void _Process(double delta){
        
    }

    public void OnPressed(){
        GD.Print("button is pressed");
    }
}