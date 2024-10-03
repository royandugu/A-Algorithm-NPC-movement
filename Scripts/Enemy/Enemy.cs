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

        var regionSizeRough = aStarGrid2D.Region.Size;
        var regionPositionRough = aStarGrid2D.Region.Position;
        var tilePositionFare = new Vector2I(regionSizeRough.X + regionPositionRough.X, regionSizeRough.Y + regionPositionRough.Y);

    }
    public override void _Process(double delta){

    }
}