using Godot;
public partial class Enemy:Node2D{
    private AStarGrid2D aStarGrid2D;
    public override void _Ready(){
        aStarGrid2D=new AStarGrid2D();
    }
    public override void _Process(double delta){

    }
}