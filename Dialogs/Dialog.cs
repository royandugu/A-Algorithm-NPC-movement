using Godot;

public partial class Dialog : MarginContainer
{
    [Export]
    private Label label;
    [Export]
    private Timer timer;
    private int maxWidth=256, letterIndex=0;
    private float letterTime=0.03f, spaceTime=0.06f, punchuationTime=0.2f;
    private string text;
     public override void _Ready()
    {
        //So basically what we can do is here we can connect to the resize signal and then 
    }
    public async void DisplayText(string textToDisplay){
        text=textToDisplay;
        label.Text=textToDisplay;   
    }
     private void OnResize()
    {
        // Signal that the resize event has occurred
    }
}