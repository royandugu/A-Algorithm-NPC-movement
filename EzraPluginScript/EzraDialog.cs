using System.Collections.Generic;
using Godot;

public partial class EzraDialog:Node2D{
    [Export]
    private Label textBox; 
    PackedScene buttonScene = (PackedScene)ResourceLoader.Load("res://Scenes/ChoiceButton.tscn");
    private List<Button> buttons;
    private VBoxContainer vBoxContainer;

    public override void _Ready()
    {
        vBoxContainer = GetNode<VBoxContainer>("VBoxContainer");
    }
    public void AddText(string text){
        textBox.Text = text;
    }   

    public void AddChoice(){
        EzraChoiceButton buttonObj = (EzraChoiceButton) buttonScene.Instantiate();
        buttonObj.ChoiceIndex=buttons.Count;
        buttons.Add(buttonObj);
        vBoxContainer.AddChild(buttonObj);
    }
}