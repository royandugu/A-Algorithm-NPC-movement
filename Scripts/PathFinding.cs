using Godot;
using System;

public partial class PathFinding : TileMapLayer
{
	private AStarGrid2D aStarGrid2D;
	private Vector2I mainLayer=new Vector2I(0,0);
	private int mainSource=0;
	private Vector2I pathTakenAtlasCords=new Vector2I(0,8);

	public override void _Ready()
	{   
		SetGrid();
		ShowGrid();
	}

	public void SetGrid(){
		aStarGrid2D = new AStarGrid2D();
		aStarGrid2D.Region = new Rect2I(0,0,7,6);
		aStarGrid2D.CellSize = new Vector2I(16,16);
		aStarGrid2D.Update();
	}

	public void ShowGrid(){
		var pathTaken = aStarGrid2D.GetIdPath(new Vector2I(0,0),new Vector2I(4,0));
		foreach(var cell in pathTaken){
			SetCell(mainLayer, mainSource, pathTakenAtlasCords);
		}
	}
}
