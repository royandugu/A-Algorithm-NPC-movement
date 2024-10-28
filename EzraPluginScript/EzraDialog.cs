using Godot;

public partial class EzraDialog:Node2D{
    [Export]
    private Label textBox; 
    public void AddText(string text){
        textBox.Text = text;
    }   
}