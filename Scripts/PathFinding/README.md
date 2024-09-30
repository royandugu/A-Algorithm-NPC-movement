## PATHFINDING 

- Tutorial by Think With Games
(Read rest from the copy)

pathTaken vanne variable jun xa tyo variable shows the array of paths it will take (arguments jun pass gareko in SetCell xa tyo first two arguments tyo chain thahavayena but the last argument is the co-ordinate of the grid of Atlas and this grid will be used to draw the path on the TileMap). Now tei pathTaken laii loop garyo ra tyo jun jun path haru xa tesma draw garyo. Ho SetCell le dynamically tyo values haru ko barema vanxa.

The current Tileset that I kept as a barrier is the tile on the well on the left of gate of the well. The co-ordinates is (2,3)


## Error 1 study
Points are out of bounds error even though the points seem to exist on the Grid.


## Trial 2 

(4,6) in our Atlas TileSets is going to be the co-ordinates for the walkable on the Tile
(2,3) in our Atlas TileSets is going to be the obstacle.


## Tutorial by Retrobright
2D movement in GODOT 4 using a Tilemap by Retrobright
-- Project Settings details -- 

Setting up the viewport height and viewport width : 

1. When we setup our viewport height and viewport width in GODOT, it's like setting up the initial resolution for our game. Now when this game is played in a screen resolution, other than the previous provided then GODOT may choose to scale it or you know just to make sure our images don't look distorted when scaled, the aspect ration is maintained. Also we can choose diffrent modes like streching and all that, to match how we handle the streching.
2. Setting up window width override and window height override basically means that the game's actual size (think of it as a frame) while the viewport height and viewport width are the actual sizes where the game contents will be rendered but the override values are the frames if the viewport height and viewport width are a picture. Think of it like a small picture kept in a large frame (if the override values are bigger). Now somehow if our game is opened in a device that does no have enough resoultion for our kept override then GODOT itself resizes. Also to remember that if the override values are smaller than the actual viewport height and viewport width then the parts will be cut off. If the viewport height and viewport width is 800 by 600 but the override values are 600 and 400 only the 600 400 portions visible else will be cut off. But we can also have some options of scaling them down so that it will scale for smaller screens. 
- Two Terms 
Scaling: If you allow the game to scale, Godot might stretch the game to fit the smaller window or screen, which could cause the content to fill the screen but possibly distort if the aspect ratio changes.
Letterboxing: If the aspect ratio (width
) of the screen is different from 800x600 (e.g., on a widescreen monitor), you may see black bars on the sides or top/bottom (letterboxing/pillarboxing) to maintain the original aspect ratio without stretching the game. 
3. Setting the streched mode to canvas_item.
   Streched mode basically means that when our game is played in a diffrent screen resolution, how will it appear ? So basically if we are setting up the streched mode to canvas_item, it basically means that rather than streching the entire game world, individual canvas items will be streched. Now when this is useful when we want diffrent anvas items to appear diffrently streched. For example UI items haru ali diffrently streched ra game world ko sprites haru diffrently streched and all that. Other diffrent scaling modes can be : 
   -- Viewport 
   This means the whole of the game is scaled perfectly on the basis of our window size. If the game's and window's aspect ratio does not match then letterboxing may occur this means that black bars to appear.  
   -- Disabled
   Th
4. Default texture feature to nearest
   Basically when our games are scaled, this can affect the way the textures appear. Now to fix this we have this option called default texture feature. Based on certain options set to it, the default texture features textures in our game can appear either smooth or pixelated depending upon the options assigned to it. Basically we assign this as nearest because when our games are scaled, then no filter is applied and they can appear boxed and pixelated. Now as we aim for pixel art games this is going to be our options.
   --Linear (bilinear filtering) : Now when we assign this option, the textures are smoothed and the edges are blurred that helps smooth texture rendering when the game is scaled and that the blockiness does not appear. 
   --Trilinear : Now this is more of an advanced version of linear. Useful for 3D games.(Nearest minmap)

   ## Following the tutorial
   Co-ordinate (9,11) is the co-ordinate that is walkable
