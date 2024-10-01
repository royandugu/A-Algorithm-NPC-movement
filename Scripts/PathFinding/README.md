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

   ## A csharp rule to remember
   Kunai pani euta variable laii hami initialize gardai xau vane, tyo variable mah tei class ko arko variable rakhna mildaina until and unless that other variable is static. 
