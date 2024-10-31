So what we just did is add the buttons to our Vbox contanier from the GUI but now we are going to create a new scene and add a button into that scene and then add buttons by adding child to it rather than directly adding from the GUI. So basically hamile euta button euta naya scene mah create garyo ra tyo button ko pressed vanne signal sanga connect vayera baseko script tesma attach garyo. Then aba tyo scene laii hamro main script mah preload garera instantiate garne.

## Ezra Dialog
This is the script that is present to the main scene. Here we instantiated the scene that contained the ChoiceButton and then it also had a script assigned to it. What we did is that we accessed the variable that was present in that script, assigned the variable which is choiceIndex to the size of an array of buttons we just created in Ezra Dialog. In the function AddChoice we just instantiate the scene with the buttons and then we add that scene to our array. It's like when we have multiple choice buttons each button is from the scene. Then we can also access the VBoxContainer and then add that button as the child
Jun script hamro button matra vayeko scene ko button mah attached xa ni, ho tei script mah euta signal create gareka xau. Tyo signal sanga hami connect garxau on AddChoice function. 
A little revision that signals haru etikai hunxa, ra suppose euta button ko Pressed vanne signal etikai xa. So when that button is pressed then the signal is emitted. And when the signal is emitted, the responsibility to catch an emitted signal lies in slots.

nameof vanne variable le simply variable ko name return garxa as a string. In C# to emit a certain string we have a function known as EmitSignal and this function takes in arguments. The first argument being the name of the signal that we are trying to emit and the second parameter being the parameter that will be sent while emitting this signal.

Simple logic : ChoiceSelected vanne jaba emit hunxa tyo emit vako signal lai OnChoiceSelected vanne slot le catch garxa. Ra yo ChoiceSelected kaile emit hunxa? ChoiceSelected emit taba hunxa jaba ButtonPressed hunxa.

How does ChoiceIndex work?
Basically harek euta choiceButton jun create hunxa ni, tyo ChoiceButton sanga euta EzraChoiceButton script attached hunxa, ra harek script mah choiceIndex vanne euta variable xa. Now while adding choices, what we do is that we maintain an array. Suppose we add our first choice button. Then tyo first choice button mah vayeko script ko choiceIndex value tyo array ko length ho ni taw. So first choice button has an index 0. Then tespaxi we add another choiceButton. Tyo array ko length is now 1 so second choice button ko script mah we assign 1. So this way, kun chain choice select gareko hau vanera hamile thaha pauna sakxau.

## On the GUI 