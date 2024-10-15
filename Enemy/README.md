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