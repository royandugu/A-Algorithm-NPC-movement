using System.Collections.Generic;
using Godot;
public partial class Enemy : Node2D
{
	private AStarGrid2D aStarGrid2D;
	private TileMapLayer tileMapLayer;
	private Vector2I regionSize;
	private Vector2I regionPosition;
	[Export]
	private Sprite2D enemySprite;
	private bool isMoving;
	public override void _Ready()
	{
		isMoving=true;
		aStarGrid2D = new AStarGrid2D();
		aStarGrid2D.Region = new Rect2I(-5, -5, 9, 9);
		tileMapLayer = GetNode<TileMapLayer>("/root/Node2D/TileMapLayer");
		aStarGrid2D.CellSize = new Vector2I(16, 16);
		aStarGrid2D.Update();

		var regionSizeRough = aStarGrid2D.Region.Size;

		for (int i = 0; i < regionSizeRough.X; i++)
		{
			for (int j = 0; j < regionSizeRough.Y; j++)
			{
				var tilePosition = new Vector2I(i + regionPosition.X, j + regionPosition.Y);
				var tileData = tileMapLayer.GetCellTileData(tilePosition);
				if (tileData == null && !(bool)tileData.GetCustomData("walkables"))
				{
					aStarGrid2D.SetPointSolid(tilePosition);
				}
			}
		}

	}
	public override void _Process(double delta)
	{
		if(isMoving == true) Move();
	}

	public void Move()
	{
		var path = aStarGrid2D.GetIdPath(tileMapLayer.LocalToMap(GlobalPosition), new Vector2I(-4, -4));
		if (path.Count > 1)
		{
			path.RemoveAt(0);
		}
		else{
			return;
		}

		var originalPosition = GlobalPosition;
		GlobalPosition = tileMapLayer.MapToLocal(path[0]);
		enemySprite.GlobalPosition = originalPosition;
	}

	public override void _PhysicsProcess(double delta)
	{
		if(isMoving){
			enemySprite.GlobalPosition = enemySprite.GlobalPosition.MoveToward(GlobalPosition,1); 
		}
		if(enemySprite.GlobalPosition == GlobalPosition){
			isMoving = false;
			return;
		}
	}

}
