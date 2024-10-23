## Tutorial by Dash Nothing.

We need two things a TextBox and a DialogManager. 

## Margin container
The parent node we are going to have is the Margin container. The margin container is like our typical web div where suppose we have to add certain elements and then we have to add certain margins or paddings to it then this becomes helpful.

## Nine patch rect
Now we use Nine patch rect to keep our dialog box texture as the background. Why we do this is because the very amazing use of Nine patch rect is that while scaling the UI does not scale. Instead it tiles. Like the texture is same on the borders as the middle tiles cover up the entire space. While putting up the MarginContainer think of it like a div like div banayo tesko vitra euta NinePatchRect rakhyo tesma background rakhyo ra tesko vitra feri euta div which is the MarginContainer and then tesko vitra h3,h4s which are named label in our Godot Node. Now yei label mah hamro div mah jasto we have text-align and all of that. Now we can also setup certain fonts right there. Font color and all. For margin container go to theme overrides and constants and there give margin left right and all that. 
Now we need to add a Timer Node to it and there in the inspector we need to tick one shot. Why? This is because this Timer means that it will run once and then start, loop mah run hudaina. 

## Also see the tutorial for Dialog box by developer Exra (Can be a helpful tool to use)
Whenever you want to add any plugins, they are stored in the addons folder. For the plugin by ezra we can simply bring the plugin from the git repo and put it in the addons folder. Once you do that go to project > project settings > plugin and there we will se ezra's plugin. We can tick it enabled and as soon as we enable it we will see a Ez Dialog tab that appears beside those 2D, 3D and all that. 

Now another Node called the VBoxContainer: A VBoxContainer automatically stacks it's child nodes vertically in linear layout. The need to manually adjust positions is no more. VBoxContainer mah hamile grow settings rakhna sakxau for example when we have extra buttons below the VBox container will either grow from the top or it will grop from below so depending upon it.