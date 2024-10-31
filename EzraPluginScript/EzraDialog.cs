using System.Collections.Generic;
using System.Threading;
using Godot;

public partial class EzraDialog:Node2D{
	private PackedScene buttonScene; 
	private EzraChoiceButton buttonObj;
	private List<Button> buttons;
	private VBoxContainer vBoxContainer;

	public override void _Ready()
	{
		vBoxContainer = GetNode<VBoxContainer>("VBoxContainer");
		buttonScene= (PackedScene)ResourceLoader.Load("res://Scenes/ChoiceButton.tscn");
		buttons = new List<Button>();
		AddChoice("This is choice one");
		AddChoice("This is choice two");   
	}

	public void AddChoice(string choiceText){
		buttonObj = (EzraChoiceButton) buttonScene.Instantiate();
		buttonObj.ChoiceIndex=buttons.Count;
		buttonObj.ChoiceSelected += OnChoiceSelected;
		buttons.Add(buttonObj);
		buttonObj.Text = choiceText;
		vBoxContainer.AddChild(buttonObj);
	}

	public void ClearAll(){
		foreach (var button in buttons){
			vBoxContainer.RemoveChild(button);
		}
		buttons.Clear();
	}

	public void OnChoiceSelected(int selectedChoice){
		GD.Print("selected choice", selectedChoice);
		ClearAll();
	}
}
