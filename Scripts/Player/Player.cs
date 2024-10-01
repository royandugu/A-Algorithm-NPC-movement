using Godot;

public partial class Player:Node2D{
	private TileMapLayer tileMapLayer;
	private Vector2I currentTile;
	private Vector2I tileToMoveTo;
	private TileData tileData;
	public override void _Ready()
	{
		tileMapLayer = GetNode<TileMapLayer>("/root/Node2D/TileMapLayer");
	}
	public override void _Process(double delta)
	{
		if(Input.IsActionPressed("ui_up")){
			MovePlayer(Vector2I.Up);
		}
		else if(Input.IsActionPressed("ui_down")){
			MovePlayer(Vector2I.Down);
		}
		else if(Input.IsActionPressed("ui_left")){
			MovePlayer(Vector2I.Left);
		}
		else if(Input.IsActionPressed("ui_right")){
			MovePlayer(Vector2I.Right);
		}
	}

	public void MovePlayer(Vector2I direction){
		currentTile = tileMapLayer.LocalToMap(GlobalPosition);
		tileToMoveTo = new Vector2I(currentTile.X + direction.X, currentTile.Y + direction.Y);
		tileData = tileMapLayer.GetCellTileData(tileToMoveTo);
		if((bool)tileData.GetCustomData("walkables")){
			GlobalPosition = tileMapLayer.MapToLocal(tileToMoveTo);
		}
	}
}
