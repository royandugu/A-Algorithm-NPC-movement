using Godot;
public partial class Enemy:Node2D{
    private AStarGrid2D aStarGrid2D;
    private TileMapLayer tileMapLayer;
    private Vector2I regionSize;
    private Vector2I regionPosition;
    public override void _Ready(){
        aStarGrid2D=new AStarGrid2D();
        tileMapLayer = GetNode<TileMapLayer>("/root/Node2D/TileMapLayer");
        aStarGrid2D.CellSize = new Vector2I(16,16);
        aStarGrid2D.Update();

        regionSize = aStarGrid2D.Region.Size;
        regionPosition = aStarGrid2D.Region.Position;
    }
    public override void _Process(double delta){

    }
}