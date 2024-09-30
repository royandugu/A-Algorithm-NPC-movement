using Godot;

public partial class Player:Node2D{
    
    public override void _Process(double delta)
    {
        if(Input.IsActionPressed("ui_up")){
            MovePlayer(Vector2.Up);
        }
        else if(Input.IsActionPressed("ui_down")){
            MovePlayer(Vector2.Down);
        }
        else if(Input.IsActionPressed("ui_left")){
            MovePlayer(Vector2.Left);
        }
        else if(Input.IsActionPressed("ui_right")){
            MovePlayer(Vector2.Right);
        }
    }

    public void MovePlayer(Vector2 direction){
    }
}

