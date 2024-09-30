using Godot;
using System;

public partial class PathFinding : TileMapLayer
{
	private AStarGrid2D aStarGrid2D;
	private Vector2I mainLayer=new Vector2I(0,0);
	private int mainSource=0;
	private Vector2I pathTakenAtlasCords=new Vector2I(0,8);

	private string isObstacle="isObstacle";
	public override void _Ready()
	{   
		SetGrid();
		ShowGrid();
	}

	public void SetGrid(){
		aStarGrid2D = new AStarGrid2D();
		aStarGrid2D.Region = new Rect2I(0,0,5,5);
		aStarGrid2D.CellSize = new Vector2I(16,16);
		aStarGrid2D.Update();
		foreach(var cell in GetUsedCells()){
			aStarGrid2D.SetPointSolid(cell,IsSpotSolid(cell));
		}
	}

	public void ShowGrid(){
		var pathTaken = aStarGrid2D.GetIdPath(new Vector2I(0,0),new Vector2I(5,3));
		foreach(var cell in pathTaken){
			SetCell(new Vector2I(0,0), mainSource, pathTakenAtlasCords);
		}
	}

	public bool IsSpotSolid(Vector2I spotToCheck){
		var result= GetCellTileData(spotToCheck).GetCustomData(isObstacle);
		if((bool)result) return true;
		else return false;
	}
}
