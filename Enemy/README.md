# Tutorial by RetroBright

## Enemny movement
Right now we are basically applying the algorithm of enemy running after the player but what we truly want is enemy avoiding the player (cause it's going to be NPC in our game). So initially AStarGrid lai initialize garepaxi tesma diffrent values haru hamile set garna milxa. Like cell sizes and we can set that we should not have any diagnol movements. After setting all these vaues then we use Update() to update the values set from defaults.

We get the regionSize and then we get the regionPosition. With the help of these two, we get the TilePosition that is new Vector2I(regionSize.X+regionPosition.X, ....same). Now on this TilePosition, I check if it is walkable or not.

-- As per my understanding, what we are doing is we are extracting the size of our AStarGrid2D this means that the width of our AStarGrid2D and height of our AStarGrid2D. Then we extract the initial position of our AStarGrid2D. What we do is we add the initial position of our AStarGrid2D with the size that is the height and width of our AStarGrid2D. All I know for now is this point gives the end point of our AStarGrid2D. 

What he did was he first found out the size of the AStarGrid2D it gives like in co-ordinates it's size. Now for loop lagayam euta integer mah vane, the loop goes from 0 to n-1 if n be that integer. So total size aune vayo. So what he is doing is: 
Suppose hamro AStarGrid ko size aayo (16,16) ayo vane 
        for loop that goes from 0 to 15 (for the x)
            nested for loop that goes from 0 to 15 (for the y)


## 15th october error count
1. Why is the size of my AStarGrid2D 0 ? 
Ok the cellSize we are assigning is initially the size of a single cell it is not the area region of the entire AStarGrid2D. Also remember that till now we have not done anything related to that of the TileMap. We have jsut imported it. For the AStarGrid2D we are just setting the CellSize.

## Calculating tilePosition
What we just did is that we are iterating from 0 to the total size of the AStarGrid-1 so basically tyo duita nested loop le vaye var ko sabai co-ordinates haru dinxa. So yesle k garna khojeko vanda, yo iterated values haru laii starting point sanga add garne. For example, if our AStarGrid2D starts at 1,1 then 0,0 mah check garera taw kaam banena ni taw. So position.x+0 which is 1 and position.y+0 which is 1 so (1,1) bata start hune vayo. Basically grid jata bata suru hunxa tetai bata taw start hunu paryo ni. So yesari harek euta point laii hami nikalxau ra tyo harek point ko tileMap mah value k xa tyo nikalxam. So basically tileMap mah tyo point mah walkable xa ni naui ?

Now what we did is we parsed through every single possible points, and then we checked whether those points in the tilemap has our custom data that we created naming it walkables. Now if it does not contain then we use the function called SetPointSolid. What this function does is that hamro AStarGrid mah tyo point laii solid vanera xutyauxa vanepaxi tyo point is impassable. So while moving avoidance will occur.

Now in Process we call a function called Move. What move function does is that firstly it finds out the path. Here we use aStarGrid2D.GetIdPath to get the path and inside of this path we give the starting co-ordinates and the final co-ordinates. Basically, euta starting point diyo yeslai ra euta ending point diyo. And then we say ki yo starting point bata yo ending point samma jaane bato dekhau while avoiding all the tiles that does not have a walkable as we set them as solid in Ready function. So yesle AStar path finding algorithm lagauxa and then it gives the path. Our path is going to be an array and now the first element of the array is going to be the current position so we need to pop them. Also I just figured out that we have two arrays here, one being the Godot array and the another being the .NET array. These two are diffrent arrays. And the GetIdPath function returns the Godot Array. Now the after we check that the Array path has more than two elements we set the global position of our enemy as the corresponding local position of the first element of our path. 

Now to move the spirte what the tutorial dude does is that initially the spirte's position is set to the original position. Then only in Physics Process we move the Sprite towards the GlobalPosition of the Node by only 1 step. 

Now euta variable xa isMoving. Now when the enemey reaches the destination then the GlobalPosition of the Node becomes equal to the GlobalPosition of the sprite. At such moment the isMoving is set to false. When isMoving is set false then no operation takes place.

Basically Node pahila nai destination mah pugxa vane Sprite bistarai one one step gardai destination tira hidxa.